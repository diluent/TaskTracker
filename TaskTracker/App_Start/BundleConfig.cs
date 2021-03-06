﻿using BundleTransformer.Core.Bundles;
using BundleTransformer.Core.Orderers;
using BundleTransformer.Core.Transformers;
using System.Web.Optimization;

namespace TaskTracker
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;
            var cssTransformer = new StyleTransformer();
            var jsTransformer = new ScriptTransformer();
            var nullOrderer = new NullOrderer();

            var cssBundle = new StyleBundle("~/bundles/css");
            cssBundle.Include("~/Content/Site.less", "~/Content/bootstrap/bootstrap.less");
            cssBundle.Transforms.Add(cssTransformer);
            cssBundle.Orderer = nullOrderer;
            bundles.Add(cssBundle);

            var commonBundle = new ScriptBundle("~/bundles/common");
            commonBundle.Include("~/Scripts/jquery-{version}.js")
                        .Include("~/Scripts/jquery.validate*")
                        .Include("~/Scripts/modernizr-*")
                        .Include("~/Scripts/respond.js")
                        .Include("~/Scripts/knockout-{version}.js");
            commonBundle.Transforms.Add(jsTransformer);
            commonBundle.Orderer = nullOrderer;
            bundles.Add(commonBundle);

            //var jqueryBundle = new ScriptBundle("~/bundles/jquery");
            //jqueryBundle.Include("~/Scripts/jquery-{version}.js");
            //jqueryBundle.Transforms.Add(jsTransformer);
            //jqueryBundle.Orderer = nullOrderer;
            //bundles.Add(jqueryBundle);

            //var jqueryvalBundle = new ScriptBundle("~/bundles/jqueryval");
            //jqueryvalBundle.Include("~/Scripts/jquery.validate*");
            //jqueryvalBundle.Transforms.Add(jsTransformer);
            //jqueryvalBundle.Orderer = nullOrderer;
            //bundles.Add(jqueryvalBundle);

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.

            //var modernizrBundle = new ScriptBundle("~/bundles/modernizr");
            //modernizrBundle.Include("~/Scripts/modernizr-*");
            //modernizrBundle.Transforms.Add(jsTransformer);
            //modernizrBundle.Orderer = nullOrderer;
            //bundles.Add(modernizrBundle);

            //var bootstrapBundle = new ScriptBundle("~/bundles/bootstrap");
            //bootstrapBundle.Include("~/Scripts/bootstrap.js", "~/Scripts/respond.js");
            //bootstrapBundle.Transforms.Add(jsTransformer);
            //bootstrapBundle.Orderer = nullOrderer;
            //bundles.Add(bootstrapBundle);

            //var knockoutBundle = new ScriptBundle("~/bundles/knockout");
            //knockoutBundle.Include("~/Scripts/knockout-{version}.js");
            //knockoutBundle.Transforms.Add(jsTransformer);
            //knockoutBundle.Orderer = nullOrderer;
            //bundles.Add(knockoutBundle);
        }
    }
}