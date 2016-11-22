﻿namespace Microsoft.ApplicationInsights.AspNetCore.Extensions
{
    using System.Reflection;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Application Insights service options defines the custom behavior of the features to add, as opposed to the default selection of featuers obtained from Application Insights.
    /// </summary>
    public class ApplicationInsightsServiceOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInsightsServiceOptions" /> class.
        /// Application Insights service options that controlls the default behavior of application insights features.
        /// </summary>
        public ApplicationInsightsServiceOptions()
        {
            this.EnableQuickPulseMetricStream = true;
            this.EnableAdaptiveSampling = true;
            this.ApplicationVersion = Assembly.GetEntryAssembly().GetName().Version.ToString();
        }

        /// <summary>
        /// Gets or sets a value indicating whether QuickPulseTelemetryModule and QuickPulseTelemetryProcessor are registered with the configuration.
        /// Setting EnableQuickPulseMetricStream to false, will disable the default quick pulse metric stream. Defaults to <code>true</code>.
        /// </summary>
        public bool EnableQuickPulseMetricStream { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether telemetry processor that controls sampling is added to the service.
        /// Setting EnableAdaptiveSampling to false, will disable the default adaptive sampling feature. Defaults to <code>true</code>.
        /// </summary>
        public bool EnableAdaptiveSampling { get; set; }

        /// <summary>
        /// Gets or sets the default instrumentation key for the application.
        /// </summary>
        public string InstrumentationKey { get; set; }

        /// <summary>
        /// Gets or sets the application version reported with telemetries.
        /// </summary>
        public string ApplicationVersion { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether telemetry channel should be set to developer mode.
        /// </summary>
        public bool? DeveloperMode { get; set; }

        /// <summary>
        /// Gets or sets the endpoint address of the channel.
        /// </summary>
        public string EndpointAddress { get; set; }
    }
}
