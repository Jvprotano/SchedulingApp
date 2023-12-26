using AppAgendamentos.Contracts.Services;
using AppAgendamentos.Controllers.BaseControllers;
using AppAgendamentos.Models;
using AppAgendamentos.ViewModels;

using AutoMapper;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppAgendamentos.Controllers;

[Authorize]
[Route("[controller]/[action]")]
public class CompanyController : BaseController
{
    private readonly ICompanyService _companyService;
    private readonly IService<CompanyServiceOffered> _serviceOfferedService;
    private readonly IMapper _mapper;
    private readonly IService<City> _serviceCity;

    public CompanyController(ILogger<BaseController> logger, ICompanyService companyService,
    IService<CompanyServiceOffered> serviceOfferedService, IMapper mapper, IService<City> serviceCity) : base(logger)
    {
        _companyService = companyService;
        _serviceOfferedService = serviceOfferedService;
        _mapper = mapper;
        _serviceCity = serviceCity;
    }

    public IActionResult Index()
    {
        return RedirectToAction("Create");
    }
    [HttpGet]
    public async Task<IActionResult> Create()
    {
        var model = new CompanyViewModel
        {
            ServicesExistingOptionsSelect = (await _serviceOfferedService.GetAllAsync()).ToList()
                .DistinctBy(c => c.Name).Select(s =>
                    new SelectListItem(text: s.Name, value: s.Name.ToString())).ToList(),

            CitiesSelect = LoadCities()
        };
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CompanyViewModel model)
    {
        try
        {
            var company = _mapper.Map<Company>(model);

            if (model.ImageFile != null && model.ImageFile.Length > 0 && !model.AutoGeneratedImage)
                company.ImageBase64 = _companyService.getBase64(model.ImageFile);

            await _companyService.SaveAsync(company);
            SetMessageSuccess("Company saved successfully");
            return RedirectToAction("Index", "Home");
        }
        catch (Exception ex)
        {
            ModelState.AddModelError(string.Empty, ex.Message);
            return RedirectToAction("Create", model);
        }
    }
    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var company = await _companyService.GetByIdAsync(id);
        var model = _mapper.Map<CompanyViewModel>(company);

        if (model.OpeningHours.Count() <= 0)
            model.OpeningHours = CompanyViewModel.LoadDefaultOpeningHours();

        model.ServicesExistingOptionsSelect = (await _serviceOfferedService.GetAllAsync()).ToList()
            .DistinctBy(c => c.Name).Select(s =>
                new SelectListItem(text: s.Name, value: s.Name.ToString())).ToList();

        model.CitiesSelect = LoadCities();

        return View(model);
    }
    [HttpPost]
    public async Task<IActionResult> Edit(CompanyViewModel model)
    {
        try
        {
            var company = _mapper.Map<Company>(model);

            if (model.ImageFile != null && model.ImageFile.Length > 0 && !model.AutoGeneratedImage)
                company.ImageBase64 = _companyService.getBase64(model.ImageFile);

            await _companyService.SaveAsync(company);
            SetMessageSuccess("Company updated successfully");
            return RedirectToAction("Index", "Home");
        }
        catch (Exception ex)
        {
            ModelState.AddModelError(string.Empty, ex.Message);
            return RedirectToAction("Edit", model);
        }
    }
    public IActionResult CloseSchedule(int companyId)
    {
        throw new NotImplementedException();
    }
    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id)
    {
        var company = await _companyService.GetByIdAsync(id);
        return Ok(company);
    }
    private List<SelectListItem> LoadCities()
    {
        List<SelectListItem> cities = [new SelectListItem()];

        _serviceCity.GetAllAsync().Result.ToList().ForEach(city => cities.Add(
            new SelectListItem(text: city.Name, value: city.Id.ToString())));

        return cities;
    }
}