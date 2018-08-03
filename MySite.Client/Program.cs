using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;
using MySite.Client.Service;
using MySite.Client.Service.About.Implementation;
using MySite.Client.Service.About.Interfaces;

namespace MySite.Client
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(services =>
            {
                // Add any custom services here
                services.AddSingleton<IMenuService, MenuService>();
                services.AddSingleton<IMottoService, MottoService>();

                services.AddSingleton<IPersonalInformationService, PersonalInformationService>();
                services.AddSingleton<IRecommendationService, RecommendationService>();
                services.AddSingleton<ISkillService, SkillService>();
                services.AddSingleton<IThirdPartyAppService, ThirdPartyAppService>();
                services.AddSingleton<IAdmiredPersonService, AdmiredPersonService>();
                services.AddSingleton<IAwardService, AwardService>();
                services.AddSingleton<ICertificateService, CertificateService>();
                services.AddSingleton<ICourseService, CourseService>();
                services.AddSingleton<IEducationService, EducationService>();
                services.AddSingleton<IExperienceService, ExperienceService>();
                services.AddSingleton<ILanguageSkillService, LanguageSkillService>();
                services.AddSingleton<IPublicationService, PublicationService>();
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}