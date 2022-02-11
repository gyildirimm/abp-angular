using AbpAngularExample.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpAngularExample;

[DependsOn(
    typeof(AbpAngularExampleEntityFrameworkCoreTestModule)
    )]
public class AbpAngularExampleDomainTestModule : AbpModule
{

}
