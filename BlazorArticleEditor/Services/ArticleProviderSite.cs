﻿
using BlazorArticleEditor.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;

namespace BlazorArticleEditor.Services
{
    public class ArticleProviderSite : ArticleProviderBase
    {

        public ArticleProviderSite(NavigationManager Navigation, IHttpClientFactory ClientFactory, IOptions<AppConfig> Config)
            : base(Navigation, ClientFactory, Config)
        {
            
        }

        /*** ARTICLE INTERFACES ****/

        public Task<ModelArticle?> GetArticleAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<ModelArticle?> GetArticleByNameAsync(string name)
        {
            string ArticlesBasePath = _config.Value.SourceArticle;
            string siteBaseUrl = _navigation.BaseUri;

            ModelArticle? article = null;

            using (var client = _httpClientFactory.CreateClient("default"))
            {
                string url = $"{siteBaseUrl}{ArticlesBasePath}/{name}.html";

                article = new Models.ModelArticle()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = name,
                    Content = await client.GetStringAsync(url)

                };

                return article;
            }


        }

        /*** STYLE INTERFACES ****/

        public Task<ModelArticleStyle?> GetStyleAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<ModelArticleStyle?> GetStyleByNameAsync(string styleName)
        {
            string ArticlesStyleBasePath = _config.Value.SourceArticleStyle;
            string siteBaseUrl = _navigation.BaseUri;

            ModelArticleStyle? style = null;
            //
            using (var client = _httpClientFactory.CreateClient("default"))
            {
                string url = $"{siteBaseUrl}{ArticlesStyleBasePath}/{styleName}.css";
                style = new ModelArticleStyle()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = styleName,
                    Content = await client.GetStringAsync(url)
                };

                return style;

            }
        }

    }
}
