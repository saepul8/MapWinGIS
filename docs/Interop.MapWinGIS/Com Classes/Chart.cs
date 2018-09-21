﻿#if nsp
namespace MapWinGIS
{
#endif
    using System;
    /// <summary>
    /// Represents a single chart on the map.
    /// </summary>
    /// \dot
    /// digraph chart_diagram {
    /// nodesep = 0.3;
    /// ranksep = 0.3;
    /// splines = ortho;
    /// 
    /// node [shape= "polygon", peripheries = 3, fontname=Helvetica, fontsize=9, color = gray, style = filled, height = 0.2, width = 0.8];
    /// lb [ label="Chart" URL="\ref Chart"];
    /// 
    /// node [color = tan peripheries = 1 height = 0.3, width = 1.0];
    /// lbs [ label="Charts" URL="\ref Charts"];
    /// 
    /// edge [ dir = "none", arrowhead="open", style = solid, fontname = "Arial", fontsize = 9, fontcolor = blue, color = "#606060", labeldistance = 0.6 ]
    /// lbs -> lb [ URL="\ref Charts.get_Chart()", tooltip = "Charts.get_Chart()", headlabel = "   n"];
    /// }
    /// \enddot
    /// 
    /// <a href = "diagrams.html">Graph description</a>\n\n
    /// <remarks>The number of bars or sectors depends on the number of charts fields specified in the instance of the Charts class it belongs to.
    /// In the same way the visualization options depends in the corresponding settings of the Charts class. 
    /// Each chart borrows it's data from attribute table of shapefile (see Table). So the only way to change the height of individual 
    /// bars is to modify the values in the underlying .dbf table.\n\n
    /// This class isn't meant for creation of the new charts but only for modification of position and 
    /// visibility of the existing ones. Initially charts are generated by using Charts.Generate() method.
    /// Afterwards to access a single chart Charts.get_Chart() property can be used.</remarks>
    /// \code
    /// // let's assume we need to change the properties of the chart for the 17-th shape of the shapefile
    /// public void ModifyChart(AxMap map, Shapefile sf)
    /// {
    ///    int shapeIndex = 16;    // shape indices are 0-based
    ///    
    ///    // retrieving chart object
    ///    Chart chart = sf.Charts.get_Chart(shapeIndex);
    ///    if (chart != null)
    ///    {
    ///        // is it currently displayed on the screen?
    ///        MessageBox.Show("The chart is drawn: " + chart.IsDrawn.ToString());
    ///        
    ///        chart.PositionX += 10.0;    // let's move it to the right by 10 map units
    ///        chart.PositionY -= 5.0;     // let's move it to the bottom by 5 map units
    ///        chart.Visible = true;       // ensure that it's visible
    ///        map.Redraw();   // redraw is needed to see the changes of position
    ///    }
    ///    else
    ///    {
    ///        MessageBox.Show(string.Format("The chart with index {0} doesn't exists", shapeIndex));
    ///    }
    /// }
    /// \endcode
    /// \new48 Added in version 4.8
    #if nsp
         #if upd    
            public class Chart : IChart
        #else        
            public class IChart        
        #endif
    #else
        public class Chart
     #endif
    {
        #region IChart Members
        /// <summary>
        /// Returns a boolean value which indicates whether the chart is currently displayed on the map.
        /// </summary>
        /// <remarks>%Chart can be left undrawn because of the following reasons:
        /// - shapefile layer is set invisible;
        /// - dynamic visibility activated for the shapefile layer or charts;
        /// - chart is located outside the current map extents;
        /// - all the charts or this particular chart were set to be invisible;
        /// - it overlaps already drawn charts and Charts.AvoidCollisions is set to true.</remarks>
        public bool IsDrawn
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or set the horizontal position of chart in map units.
        /// </summary>
        public double PositionX
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets the vertical position of the chart in map units.
        /// </summary>
        public double PositionY
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Returns the rectangle which the chart occupies on the screen.
        /// </summary>
        /// <remarks>This property will return NULL in case Chart.IsDrawn returns false.</remarks>
        public Extents ScreenExtents
        {
            get
            {
                throw new NotImplementedException();
            }
        }



//        public Extents ScreenExtents
//        {
//            get { throw new NotImplementedException(); }
//        }

        /// <summary>
        /// Gets or sets the value which indicates whether the chart should be drawn on the map.
        /// </summary>
        /// <remarks>Setting this property to true doesn't mean that it actually will be displayed on the map (see Chart.IsDrawn).</remarks>
        public bool Visible
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        #endregion
    }
#if nsp
}
#endif
