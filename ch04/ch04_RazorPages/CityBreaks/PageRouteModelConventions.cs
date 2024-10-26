﻿// Listing 4.8 Creating a PageRouteModelConvention to add a custom route convention in PageRouteModelConventions.cs in the CityBreaks folder

using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace CityBreaks
{
    public class PageRouteModelConventions
    {
        public class CultureTemplatePageRouteModelConvention 
            : IPageRouteModelConvention
        {
            public void Apply(PageRouteModel model)
            {
                foreach ( var selector in model.Selectors)
                {
                    model.Selectors.Add(new SelectorModel
                    {
                        AttributeRouteModel = new AttributeRouteModel
                        {
                            Order = 100,
                            Template = AttributeRouteModel.CombineTemplates("{culture?}",
                                selector.AttributeRouteModel.Template)
                        }
                    });
                }
            }
        }
    }
}
