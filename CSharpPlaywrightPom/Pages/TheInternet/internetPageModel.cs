using System.Threading.Tasks;
using Microsoft.Playwright;
using internet.Base;


namespace internet.Pages
{
    public class InternetPageModel : BasePage
    {



        public InternetPageModel(IPage page) : base(page)
        {


        }


        /// <summary>
        /// Go to Internet page
        /// </summary>
        /// <returns></returns>
        public async Task GotoAsync(AnnotationType annotationType = AnnotationType.Step) => await this.GotoPageAsync("https://the-internet.herokuapp.com/");




        private ILocator abTestingLink()
        {
            return this.Page.Locator("#content  ul li:nth-child(1) a");
        }





        private ILocator challengingDOMLink()
        {
            return this.Page.Locator("#content  ul li:nth-child(5) a");
        }




        private ILocator digestAuthenticationLink()
        {
            return this.Page.Locator("#content  ul li:nth-child(8) a");
        }


        private ILocator dynamicLoadingLink()
        {
            return this.Page.Locator("#content  ul li:nth-child(14) a");
        }

        private ILocator entryAdLink()
        {
            return this.Page.Locator("#content  ul li:nth-child(15) a");
        }

        private ILocator exitIntentLink()
        {
            return this.Page.Locator("#content  ul li:nth-child(16) a");
        }


        private ILocator fileUploadLink()
        {
            return this.Page.Locator("#content  ul li:nth-child(18) a");
        }

        private ILocator floatingMenu()
        {
            return this.Page.Locator("#content  ul li:nth-child(19) a");
        }

        private ILocator forgotPasswordLink()
        {
            return this.Page.Locator("#content  ul li:nth-child(20) a");
        }

        private ILocator formAuthenticationLink()
        {
            return this.Page.Locator("#content  ul li:nth-child(21) a");
        }

        private ILocator framesLink()
        {
            return this.Page.Locator("#content  ul li:nth-child(22) a");
        }

        private ILocator geolocationLink()
        {
            return this.Page.Locator("#content  ul li:nth-child(23) a");
        }

        private ILocator horizontalSliderLink()
        {
            return this.Page.Locator("#content  ul li:nth-child(24) a");
        }

        private ILocator hoversLink()
        {
            return this.Page.Locator("#content  ul li:nth-child(25) a");
        }

        private ILocator infiniteScrollLink()
        {
            return this.Page.Locator("#content  ul li:nth-child(26) a");
        }

        private ILocator inputsLink()
        {
            return this.Page.Locator("#content  ul li:nth-child(27) a");
        }


    }
}