using System;
using System.Web;
using Elmah;

namespace SmarkBotTestForm
{
    public static class ElmahExtension
    {
        private static HttpApplication httpApplication = null;
        private static ErrorFilterConsole errorFilter = new ErrorFilterConsole();

        public static ErrorMailModule ErrorEmail = new ErrorMailModule();
        public static ErrorLogModule ErrorLog = new ErrorLogModule();

        public static void LogToElmah(this Exception ex)
        {
            if (HttpContext.Current != null)
            {
                ErrorSignal.FromCurrentContext().Raise(ex);
            }
            else
            {
                if (httpApplication == null) InitNoContext();
                ErrorSignal.Get(httpApplication).Raise(ex);
            }
        }
        public static void LogToElmah(string Message)
        {
            new ElmahMessageLevelException(Message).LogToElmah();
        }

        private static void InitNoContext()
        {
            httpApplication = new HttpApplication();
            errorFilter.Init(httpApplication);

            (ErrorEmail as IHttpModule).Init(httpApplication);
            var email = new Elmah.ErrorMailModule();
            errorFilter.HookFiltering(ErrorEmail);

            (ErrorLog as IHttpModule).Init(httpApplication);
            errorFilter.HookFiltering(ErrorLog);

        }

        private class ErrorFilterConsole : ErrorFilterModule
        {
            public void HookFiltering(IExceptionFiltering module)
            {
                module.Filtering += new ExceptionFilterEventHandler(base.OnErrorModuleFiltering);
            }
        }
    }
}