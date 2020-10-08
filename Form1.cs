using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace VectorTiles {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            MapControl map = new MapControl() {
                Dock = DockStyle.Fill,
                CenterPoint = new GeoPoint(51.5, 0),
                //ZoomLevel = 14 //road names for screenshot 1
                //ZoomLevel = 13.5 //fractional zoom level for screenshot 2
                ZoomLevel = 17 //overscaled zoom level for screenshot 3
            };
            ImageLayer layer = new ImageLayer();
            MbTilesDataProvider dataProvider = new MbTilesDataProvider() { FileUri = new Uri(@"\\corp\internal\common\4pshenichny\VectorTileRenderer\2017-07-03_great-britain_england.mbtiles") };
            layer.DataProvider = dataProvider;
            map.Layers.Add(layer);
            Controls.Add(map);
        }
    }
}
