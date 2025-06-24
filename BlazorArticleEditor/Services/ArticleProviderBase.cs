using BlazorArticle;
using BlazorArticleEditor.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;

namespace BlazorArticleEditor.Services
{
    public abstract class ArticleProviderBase : IArticleProvider<ModelArticle, string>, IArticleStyleProvider<ModelArticleStyle, string>
    {
        protected readonly NavigationManager _navigation;
        protected readonly IHttpClientFactory _httpClientFactory;
        protected readonly IOptions<AppConfig> _config;

        public ArticleProviderBase(NavigationManager Navigation, IHttpClientFactory ClientFactory, IOptions<AppConfig> Config)
        {
            _navigation = Navigation;
            _httpClientFactory = ClientFactory;
            _config = Config;
        }

        public Task<ModelArticle> GetArticleAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ModelArticle> GetArticleByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ModelArticleStyle> GetStyleAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ModelArticleStyle> GetStyleByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
