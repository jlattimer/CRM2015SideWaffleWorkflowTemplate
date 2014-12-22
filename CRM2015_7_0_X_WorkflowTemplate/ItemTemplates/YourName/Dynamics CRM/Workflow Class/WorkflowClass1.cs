using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;

namespace $rootnamespace$
{
    public class $fileinputname$ : CodeActivity
    {
        private ITracingService _tracingService;
        private IOrganizationService _service;

        protected override void Execute(CodeActivityContext executionContext)
        {
            try
            {
                _tracingService = executionContext.GetExtension<ITracingService>();
                IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
                IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
                _service = serviceFactory.CreateOrganizationService(context.UserId);

                //Do stuff
            }
            catch (Exception ex)
            {
                _tracingService.Trace("Exception: {0}", ex.ToString());
            }
        }
    }
}
