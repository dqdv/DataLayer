﻿/*
Copyright(c) <2018> <University of Washington>
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

namespace DataLayer
{
    public class ChartPreferences
    {
        /// <summary>
        /// Indicates if legend should be shown
        /// </summary>
        public bool LegendShowen { get; set; }
        /// <summary>
        /// Gets or sets point size on the chart
        /// </summary>
        public int PointSize { get; set; }
        /// <summary>
        /// Indicates if grid line should be shown for X axis
        /// </summary>
        public bool XLineVisible { get; set; }
        /// <summary>
        /// Indicates if grid line should be shown for Y axis
        /// </summary>
        public bool YLineVisible { get; set; }
        /// <summary>
        /// Gets or sets font size for labels on the chart
        /// </summary>
        public int FontSize { get; set; }
        /// <summary>
        /// Gets or sets font family for labels on the chart
        /// </summary>
        public string FontFamilyName { get; set; }
        /// <summary>
        /// Gets or sets palette collors for the chart lines
        /// </summary>
        public string[] PaletteColors { get; set; }
    }
}