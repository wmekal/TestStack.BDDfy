﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.544
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bddify.Processors.HtmlReporter {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class HtmlReportResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal HtmlReportResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Bddify.Processors.HtmlReporter.HtmlReportResources", typeof(HtmlReportResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///// Copyright (C) 2011, Mehdi Khalili
        ///// All rights reserved.
        ///// 
        ///// Redistribution and use in source and binary forms, with or without
        ///// modification, are permitted provided that the following conditions are met:
        /////     * Redistributions of source code must retain the above copyright
        /////       notice, this list of conditions and the following disclaimer.
        /////     * Redistributions in binary form must reproduce the above copyright
        /////       notice, this list of conditions and the following disclaime [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string bddify_css {
            get {
                return ResourceManager.GetString("bddify_css", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to $(function () {
        ///    $(&apos;.canToggle&apos;).each(function () {
        ///        var target = $(&apos;#&apos; + $(this).data(&apos;toggle-target&apos;));
        ///        target.hide();
        ///        $(this).click(function () {
        ///            target.toggle(200);
        ///        });
        ///    });
        ///
        ///    $(&apos;.expandAll&apos;).click(function () {
        ///        $(&apos;.steps&apos;).css(&apos;display&apos;, &apos;&apos;);
        ///    });
        ///    $(&apos;.collapseAll&apos;).click(function () {
        ///        $(&apos;.steps&apos;).css(&apos;display&apos;, &apos;none&apos;);
        ///    });
        ///});.
        /// </summary>
        internal static string bddify_js {
            get {
                return ResourceManager.GetString("bddify_js", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*! jQuery v1.7.1 jquery.com | jquery.org/license */
        ///(function(a,b){function cy(a){return f.isWindow(a)?a:a.nodeType===9?a.defaultView||a.parentWindow:!1}function cv(a){if(!ck[a]){var b=c.body,d=f(&quot;&lt;&quot;+a+&quot;&gt;&quot;).appendTo(b),e=d.css(&quot;display&quot;);d.remove();if(e===&quot;none&quot;||e===&quot;&quot;){cl||(cl=c.createElement(&quot;iframe&quot;),cl.frameBorder=cl.width=cl.height=0),b.appendChild(cl);if(!cm||!cl.createElement)cm=(cl.contentWindow||cl.contentDocument).document,cm.write((c.compatMode===&quot;CSS1Compat&quot;?&quot;&lt;!doctype html&gt;&quot;:&quot;&quot;)+&quot;&lt;html&gt;&lt;body&gt; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string jquery_1_7_1_min {
            get {
                return ResourceManager.GetString("jquery_1_7_1_min", resourceCulture);
            }
        }
    }
}
