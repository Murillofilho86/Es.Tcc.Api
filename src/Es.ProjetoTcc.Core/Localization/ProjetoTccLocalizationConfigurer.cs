using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Es.ProjetoTcc.Localization
{
    public static class ProjetoTccLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ProjetoTccConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ProjetoTccLocalizationConfigurer).GetAssembly(),
                        "Es.ProjetoTcc.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
