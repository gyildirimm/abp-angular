using Volo.Abp.Modularity;

namespace AbpAngularExample;

[DependsOn(
    typeof(AbpAngularExampleApplicationModule),
    typeof(AbpAngularExampleDomainTestModule)
    )]
public class AbpAngularExampleApplicationTestModule : AbpModule
{

}
