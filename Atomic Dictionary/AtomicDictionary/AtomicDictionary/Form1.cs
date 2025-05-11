using System.Linq.Expressions;

namespace AtomicDictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = searchButton;

        }

        Element[] periodicTable = {
    new Element("H", "Hydrogen", 1, 1.008, "1s1", "1", "1", 14.01, 20.28, 1, "Safe", "Gas"),
    new Element("He", "Helium", 2, 4.0026, "1s2", "18", "1", 0.95, 4.22, 0, "Safe", "Gas"),
    new Element("Li", "Lithium", 3, 6.94, "[He] 2s1", "1", "2", 453.69, 1560.15, 1, "Safe", "Solid"),
    new Element("Be", "Beryllium", 4, 9.0122, "[He] 2s2", "2", "2", 1560.15, 2470, 2, "Safe", "Solid"),
    new Element("B", "Boron", 5, 10.81, "[He] 2s2 2p1", "13", "2", 2349, 4200, 3, "Safe", "Solid"),
    new Element("C", "Carbon", 6, 12.011, "[He] 2s2 2p2", "14", "2", 3823, 4098, 4, "Safe", "Solid"),
    new Element("N", "Nitrogen", 7, 14.007, "1s2 2s2 2p3", "15", "2", 63.15, 77.36, 3, "Safe", "Gas"),
    new Element("O", "Oxygen", 8, 15.999, "1s2 2s2 2p4", "16", "2", 54.36, 90.20, 2, "Safe", "Gas"),
    new Element("F", "Fluorine", 9, 18.998, "1s2 2s2 2p5", "17", "2", 53.53, 85.03, 1, "Safe", "Gas"),
    new Element("Ne", "Neon", 10, 20.180, "1s2 2s2 2p6", "18", "2", 24.56, 27.07, 0, "Safe", "Gas"),
    new Element("Na", "Sodium", 11, 22.990, "[Ne] 3s1", "1", "3", 371.00, 1156.09, 1, "Safe", "Solid"),
    new Element("Mg", "Magnesium", 12, 24.305, "[Ne] 3s2", "2", "3", 923, 1091, 2, "Safe", "Solid"),
    new Element("Al", "Aluminum", 13, 26.982, "[Ne] 3s2 3p1", "13", "3", 660.32, 2519, 3, "Safe", "Solid"),
    new Element("Si", "Silicon", 14, 28.085, "[Ne] 3s2 3p2", "14", "3", 1687, 2900, 4, "Safe", "Solid"),
    new Element("P", "Phosphorus", 15, 30.974, "[Ne] 3s2 3p3", "15", "3", 44.15, 280.5, 3, "Safe", "Solid"),
    new Element("S", "Sulfur", 16, 32.06, "[Ne] 3s2 3p4", "16", "3", 115.21, 444.6, 2, "Safe", "Solid"),
    new Element("Cl", "Chlorine", 17, 35.45, "[Ne] 3s2 3p5", "17", "3", 171.6, 239.11, 1, "Safe", "Gas"),
    new Element("Ar", "Argon", 18, 39.948, "[Ne] 3s2 3p6", "18", "3", 83.80, 87.30, 0, "Safe", "Gas"),
    new Element("K", "Potassium", 19, 39.098, "[Ar] 4s1", "1", "4", 336.53, 759, 1, "Safe", "Solid"),
    new Element("Ca", "Calcium", 20, 40.078, "[Ar] 4s2", "2", "4", 842, 1484, 2, "Safe", "Solid"),
    new Element("Sc", "Scandium", 21, 44.956, "[Ar] 3d1 4s2", "3", "4", 1541, 2831, 3, "Safe", "Solid"),
    new Element("Ti", "Titanium", 22, 47.867, "[Ar] 3d2 4s2", "4", "4", 1668, 3287, 4, "Safe", "Solid"),
    new Element("V", "Vanadium", 23, 50.941, "[Ar] 3d3 4s2", "5", "4", 1910, 3407, 5, "Safe", "Solid"),
    new Element("Cr", "Chromium", 24, 51.941, "[Ar] 3d5 4s1", "6", "4", 2180, 2671, 6, "Safe", "Solid"),
    new Element("Mn", "Manganese", 25, 54.938, "[Ar] 3d5 4s2", "7", "4", 1246, 2061, 7, "Safe", "Solid"),
    new Element("Fe", "Iron", 26, 55.845, "[Ar] 3d6 4s2", "8", "4", 1538, 2862, 2, "Safe", "Solid"),
    new Element("Co", "Cobalt", 27, 58.933, "[Ar] 3d7 4s2", "9", "4", 1495, 2927, 2, "Safe", "Solid"),
    new Element("Ni", "Nickel", 28, 58.693, "[Ar] 3d8 4s2", "10", "4", 1455, 2913, 2, "Safe", "Solid"),
    new Element("Cu", "Copper", 29, 63.546, "[Ar] 3d10 4s1", "11", "4", 1356.6, 2562, 1, "Safe", "Solid"),
    new Element("Zn", "Zinc", 30, 65.38, "[Ar] 3d10 4s2", "12", "4", 419.53, 907, 2, "Safe", "Solid"),
new Element("Ga", "Gallium", 31, 69.723, "[Ar] 3d10 4s2 4p1", "13", "4", 29.76, 2204, 3, "Safe", "Solid"),
new Element("Ge", "Germanium", 32, 72.630, "[Ar] 3d10 4s2 4p2", "14", "4", 938.25, 2833, 4, "Safe", "Solid"),
new Element("As", "Arsenic", 33, 74.922, "[Ar] 3d10 4s2 4p3", "15", "4", 817, 614, 3, "Safe", "Solid"),
new Element("Se", "Selenium", 34, 78.971, "[Ar] 3d10 4s2 4p4", "16", "4", 221, 685, 2, "Safe", "Solid"),
new Element("Br", "Bromine", 35, 79.904, "[Ar] 3d10 4s2 4p5", "17", "4", 265.8, 332.0, 1, "Safe", "Liquid"),
new Element("Kr", "Krypton", 36, 83.798, "[Ar] 3d10 4s2 4p6", "18", "4", 116.66, 171.61, 0, "Safe", "Gas"),
new Element("Rb", "Rubidium", 37, 85.468, "[Kr] 5s1", "1", "5", 312.46, 688, 1, "Safe", "Solid"),
new Element("Sr", "Strontium", 38, 87.62, "[Kr] 5s2", "2", "5", 777, 1382, 2, "Safe", "Solid"),
new Element("Y", "Yttrium", 39, 88.906, "[Kr] 4d1 5s2", "3", "5", 1526, 3337, 3, "Safe", "Solid"),
new Element("Zr", "Zirconium", 40, 91.224, "[Kr] 4d2 5s2", "4", "5", 1855, 4377, 4, "Safe", "Solid"),
new Element("Nb", "Niobium", 41, 92.906, "[Kr] 4d4 5s1", "5", "5", 2468, 4744, 5, "Safe", "Solid"),
new Element("Mo", "Molybdenum", 42, 95.95, "[Kr] 4d5 5s1", "6", "5", 2623, 4639, 6, "Safe", "Solid"),
new Element("Tc", "Technetium", 43, 98, "[Kr] 4d5 5s2", "7", "5", 2157, 4265, 7, "Radioactive", "Solid"),
new Element("Ru", "Ruthenium", 44, 101.07, "[Kr] 4d7 5s1", "8", "5", 2334, 4150, 8, "Safe", "Solid"),
new Element("Rh", "Rhodium", 45, 102.91, "[Kr] 4d8 5s1", "9", "5", 1966, 3727, 2, "Safe", "Solid"),
new Element("Pd", "Palladium", 46, 106.42, "[Kr] 4d10", "10", "5", 1554, 2963, 2, "Safe", "Solid"),
new Element("Ag", "Silver", 47, 107.87, "[Kr] 4d10 5s1", "11", "5", 961.78, 2162, 1, "Safe", "Solid"),
new Element("Cd", "Cadmium", 48, 112.41, "[Kr] 4d10 5s2", "12", "5", 321.07, 765, 2, "Safe", "Solid"),
new Element("In", "Indium", 49, 114.82, "[Kr] 4d10 5s2 5p1", "13", "5", 156.6, 2072, 3, "Safe", "Solid"),
new Element("Sn", "Tin", 50, 118.71, "[Kr] 4d10 5s2 5p2", "14", "5", 231.93, 2602, 4, "Safe", "Solid"),
new Element("Sb", "Antimony", 51, 121.76, "[Kr] 4d10 5s2 5p3", "15", "5", 630.62, 1587, 3, "Safe", "Solid"),
new Element("Te", "Tellurium", 52, 127.60, "[Kr] 4d10 5s2 5p4", "16", "5", 449.51, 988, 2, "Safe", "Solid"),
new Element("I", "Iodine", 53, 126.90, "[Kr] 4d10 5s2 5p5", "17", "5", 113.7, 184.3, 1, "Safe", "Solid"),
new Element("Xe", "Xenon", 54, 131.29, "[Kr] 4d10 5s2 5p6", "18", "5", 161.4, 165.1, 0, "Safe", "Gas"),
new Element("Cs", "Cesium", 55, 132.91, "[Xe] 6s1", "1", "6", 301.59, 671, 1, "Safe", "Solid"),
new Element("Ba", "Barium", 56, 137.33, "[Xe] 6s2", "2", "6", 727, 1640, 2, "Safe", "Solid"),
new Element("La", "Lanthanum", 57, 138.91, "[Xe] 5d1 6s2", "3", "6", 920, 3464, 3, "Safe", "Solid"),
new Element("Ce", "Cerium", 58, 140.12, "[Xe] 4f1 5d1 6s2", "4", "6", 795, 3257, 4, "Safe", "Solid"),
new Element("Pr", "Praseodymium", 59, 140.91, "[Xe] 4f3 6s2", "5", "6", 931, 3027, 5, "Safe", "Solid"),
new Element("Nd", "Neodymium", 60, 144.24, "[Xe] 4f4 6s2", "6", "6", 1021, 3127, 6, "Safe", "Solid"),
new Element("Pm", "Promethium", 61, 145, "[Xe] 4f5 6s2", "7", "6", 1042, 3000, 7, "Radioactive", "Solid"),
new Element("Sm", "Samarium", 62, 150.36, "[Xe] 4f6 6s2", "8", "6", 1072, 1900, 2, "Safe", "Solid"),
new Element("Eu", "Europium", 63, 151.96, "[Xe] 4f7 6s2", "9", "6", 822, 1522, 2, "Safe", "Solid"),
new Element("Gd", "Gadolinium", 64, 157.25, "[Xe] 4f7 5d1 6s2", "10", "6", 1313, 3273, 3, "Safe", "Solid"),
new Element("Tb", "Terbium", 65, 158.93, "[Xe] 4f9 6s2", "11", "6", 1350, 3265, 3, "Safe", "Solid"),
new Element("Dy", "Dysprosium", 66, 162.50, "[Xe] 4f10 6s2", "12", "6", 1412, 2567, 3, "Safe", "Solid"),
new Element("Ho", "Holmium", 67, 164.93, "[Xe] 4f11 6s2", "13", "6", 1474, 2720, 3, "Safe", "Solid"),
new Element("Er", "Erbium", 68, 167.26, "[Xe] 4f12 6s2", "14", "6", 1529, 2868, 3, "Safe", "Solid"),
new Element("Tm", "Thulium", 69, 168.93, "[Xe] 4f13 6s2", "15", "6", 1545, 1562, 3, "Safe", "Solid"),
new Element("Yb", "Ytterbium", 70, 173.04, "[Xe] 4f14 6s2", "16", "6", 1097, 1461, 3, "Safe", "Solid"),
new Element("Lu", "Lutetium", 71, 174.97, "[Xe] 4f14 5d1 6s2", "17", "6", 1650, 3402, 3, "Safe", "Solid"),
new Element("Hf", "Hafnium", 72, 178.49, "[Xe] 4f14 5d2 6s2", "4", "6", 2150, 4600, 4, "Safe", "Solid"),
new Element("Ta", "Tantalum", 73, 180.95, "[Xe] 4f14 5d3 6s2", "5", "6", 3017, 5458, 5, "Safe", "Solid"),
new Element("W", "Tungsten", 74, 183.84, "[Xe] 4f14 5d4 6s2", "6", "6", 3422, 5555, 6, "Safe", "Solid"),
new Element("Re", "Rhenium", 75, 186.21, "[Xe] 4f14 5d5 6s2", "7", "6", 3186, 5869, 7, "Safe", "Solid"),
new Element("Os", "Osmium", 76, 190.23, "[Xe] 4f14 5d6 6s2", "8", "6", 3033, 5027, 8, "Safe", "Solid"),
new Element("Ir", "Iridium", 77, 192.22, "[Xe] 4f14 5d7 6s2", "9", "6", 2446, 4428, 2, "Safe", "Solid"),
new Element("Pt", "Platinum", 78, 195.08, "[Xe] 4f14 5d9 6s1", "10", "6", 1768, 3825, 2, "Safe", "Solid"),
new Element("Au", "Gold", 79, 196.97, "[Xe] 4f14 5d10 6s1", "11", "6", 1064, 2856, 1, "Safe", "Solid"),
new Element("Hg", "Mercury", 80, 200.59, "[Xe] 4f14 5d10 6s2", "12", "6", -38.83, 356.73, 2, "Safe", "Liquid"),
new Element("Tl", "Thallium", 81, 204.38, "[Xe] 4f14 5d10 6s2 6p1", "13", "6", 304, 1470, 3, "Safe", "Solid"),
new Element("Pb", "Lead", 82, 207.2, "[Xe] 4f14 5d10 6s2 6p2", "14", "6", 327.5, 1749, 4, "Safe", "Solid"),
new Element("Bi", "Bismuth", 83, 208.98, "[Xe] 4f14 5d10 6s2 6p3", "15", "6", 271.4, 1564, 3, "Safe", "Solid"),
new Element("Po", "Polonium", 84, 209, "[Xe] 4f14 5d10 6s2 6p4", "16", "6", 254, 962, 2, "Radioactive", "Solid"),
new Element("At", "Astatine", 85, 210, "[Xe] 4f14 5d10 6s2 6p5", "17", "6", 337, 610, 1, "Radioactive", "Solid"),
new Element("Rn", "Radon", 86, 222, "[Xe] 4f14 5d10 6s2 6p6", "18", "6", 202, 211, 0, "Radioactive", "Gas"),
new Element("Fr", "Francium", 87, 223, "[Rn] 7s1", "1", "7", 27, 650, 1, "Radioactive", "Solid"),
new Element("Ra", "Radium", 88, 226, "[Rn] 7s2", "2", "7", 1410, 1413, 2, "Radioactive", "Solid"),
new Element("Ac", "Actinium", 89, 227, "[Rn] 6d1 7s2", "3", "7", 1050, 1500, 3, "Radioactive", "Solid"),
new Element("Th", "Thorium", 90, 232.04, "[Rn] 6d2 7s2", "4", "7", 1750, 4780, 4, "Radioactive", "Solid"),
new Element("Pa", "Protactinium", 91, 231.04, "[Rn] 5f2 6d1 7s2", "5", "7", 1560, 4131, 5, "Radioactive", "Solid"),
new Element("U", "Uranium", 92, 238.03, "[Rn] 5f3 6d1 7s2", "6", "7", 1135, 4131, 6, "Radioactive", "Solid"),
new Element("Np", "Neptunium", 93, 237, "[Rn] 5f4 6d1 7s2", "7", "7", 912, 4131, 7, "Radioactive", "Solid"),
new Element("Pu", "Plutonium", 94, 244, "[Rn] 5f6 7s2", "8", "7", 640, 3228, 6, "Radioactive", "Solid"),
new Element("Am", "Americium", 95, 243, "[Rn] 5f7 7s2", "9", "7", 1050, 2607, 4, "Radioactive", "Solid"),
new Element("Cm", "Curium", 96, 247, "[Rn] 5f7 6d1 7s2", "10", "7", 1340, 3110, 4, "Radioactive", "Solid"),
new Element("Bk", "Berkelium", 97, 247, "[Rn] 5f9 7s2", "11", "7", 986, 2500, 4, "Radioactive", "Solid"),
new Element("Cf", "Californium", 98, 251, "[Rn] 5f10 7s2", "12", "7", 900, 1470, 3, "Radioactive", "Solid"),
new Element("Es", "Einsteinium", 99, 252, "[Rn] 5f11 7s2", "13", "7", 860, 1133, 3, "Radioactive", "Solid"),
new Element("Fm", "Fermium", 100, 257, "[Rn] 5f12 7s2", "14", "7", 1527, 3000, 3, "Radioactive", "Solid"),
new Element("Md", "Mendelevium", 101, 258, "[Rn] 5f13 7s2", "15", "7", 1100, 1300, 3, "Radioactive", "Solid"),
new Element("No", "Nobelium", 102, 259, "[Rn] 5f14 7s2", "16", "7", 1024, 1250, 3, "Radioactive", "Solid"),
new Element("Lr", "Lawrencium", 103, 266, "[Rn] 5f14 6d1 7s2", "17", "7", 1627, 3325, 3, "Radioactive", "Solid"),
new Element("Rf", "Rutherfordium", 104, 267, "[Rn] 5f14 6d2 7s2", "4", "7", 2400, 5800, 4, "Radioactive", "Solid"),
new Element("Db", "Dubnium", 105, 268, "[Rn] 5f14 6d3 7s2", "5", "7", 1900, 5700, 5, "Radioactive", "Solid"),
new Element("Sg", "Seaborgium", 106, 271, "[Rn] 5f14 6d4 7s2", "6", "7", 1200, 4300, 6, "Radioactive", "Solid"),
new Element("Bh", "Bohrium", 107, 272, "[Rn] 5f14 6d5 7s2", "7", "7", 1000, 3600, 7, "Radioactive", "Solid"),
new Element("Hs", "Hassium", 108, 277, "[Rn] 5f14 6d6 7s2", "8", "7", 1260, 2000, 6, "Radioactive", "Solid"),
new Element("Mt", "Meitnerium", 109, 278, "[Rn] 5f14 6d7 7s2", "9", "7", 1100, 2000, 6, "Radioactive", "Solid"),
new Element("Ds", "Darmstadtium", 110, 281, "[Rn] 5f14 6d9 7s1", "10", "7", 1000, 2000, 4, "Radioactive", "Solid"),
new Element("Rg", "Roentgenium", 111, 282, "[Rn] 5f14 6d10 7s1", "11", "7", 1200, 2000, 3, "Radioactive", "Solid"),
new Element("Cn", "Copernicium", 112, 285, "[Rn] 5f14 6d10 7s2", "12", "7", 356, 1000, 4, "Radioactive", "Solid"),
new Element("Nh", "Nihonium", 113, 286, "[Rn] 5f14 6d10 7s2 7p1", "13", "7", 160, 1300, 3, "Radioactive", "Solid"),
new Element("Fl", "Flerovium", 114, 289, "[Rn] 5f14 6d10 7s2 7p2", "14", "7", 100, 1000, 4, "Radioactive", "Solid"),
new Element("Mc", "Moscovium", 115, 288, "[Rn] 5f14 6d10 7s2 7p3", "15", "7", 120, 1300, 3, "Radioactive", "Solid"),
new Element("Lv", "Livermorium", 116, 293, "[Rn] 5f14 6d10 7s2 7p4", "16", "7", 130, 1000, 4, "Radioactive", "Solid"),
new Element("Ts", "Tennessine", 117, 294, "[Rn] 5f14 6d10 7s2 7p5", "17", "7", 400, 700, 5, "Radioactive", "Solid"),
new Element("Og", "Oganesson", 118, 294, "[Rn] 5f14 6d10 7s2 7p6", "18", "7", 40, 60, 0, "Radioactive", "Gas")
};



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string elementName = inputBox.Text.Trim();

            if (string.IsNullOrEmpty(elementName))
            {

                //MessageBox.Show("INPUT BOX IS EMPTY!");
                Form2 temp9 = new Form2("PLEASE INSERT AN ATOM'S NAME OR SYMBOL.");
                temp9.FormClosed += Form2_FormClosed;
                this.Hide();
                temp9.Show();
                temp9.Show();

                return;
            }

            inputBox.Clear();

            for (int i = 0; i < periodicTable.Length; i++)
            {
                // Check for exact match with the element name (case-insensitive)
                if (periodicTable[i]._symbol.Equals(elementName, StringComparison.OrdinalIgnoreCase)|| periodicTable[i]._name.Equals(elementName, StringComparison.OrdinalIgnoreCase))
                {
                    string elementInfo = "Name: " + periodicTable[i]._name + "\n" +
                                         "Symbol: " + periodicTable[i]._symbol + "\n" +
                                         "State: " + periodicTable[i]._state + "\n" +
                                         "Atomic Number: " + periodicTable[i]._atomicNumber + "\n" +
                                         "Atomic Mass: " + periodicTable[i]._atomicMass + "\n" +
                                         "Group: " + periodicTable[i]._grp + "\n" +
                                         "Period: " + periodicTable[i]._period + "\n" +
                                         "Electron Configuration: " + periodicTable[i]._electronConfig + "\n" +
                                         "Melting Point: " + periodicTable[i]._meltTemp + " K\n" +
                                         "Boiling Point: " + periodicTable[i]._boilTemp + " K\n" +
                                         "Valency: " + periodicTable[i]._valency + "\n" +
                                         "Radioactive Status : " + periodicTable[i]._radioActive_status;


                    Form2 temp = new Form2(elementInfo);
                    temp.FormClosed += Form2_FormClosed;
                    this.Hide();
                    temp.Show();
                    return;
                }
            }


            string elementinfo = "ATOM NOT FOUND!!!!";
            Form2 temp5 = new Form2(elementinfo);
            temp5.FormClosed += Form2_FormClosed;
            this.Hide();
            temp5.Show();
            temp5.Show();
        }


        public class Element
        {
            private string Name;
            public string _name
            {
                get { return Name; }
            }
            private string Symbol;
            public string _symbol
            {
                get { return Symbol; }

            }
            private int AtomicNumber;
            public int _atomicNumber
            {
                get { return AtomicNumber; }
            }
            private double AtomicMass;
            public double _atomicMass
            {
                get { return AtomicMass; }
            }
            private string ElectronConfig;
            public string _electronConfig
            {
                get { return ElectronConfig; }
            }
            private string Grp;
            public string _grp
            {
                get { return Grp; }
            }
            private string Period;
            public string _period
            {
                get { return Period; }
            }

            private double MeltTemp;
            public double _meltTemp
            {
                get { return MeltTemp; }
            }
            private double BoilTemp;
            public double _boilTemp
            {
                get { return BoilTemp; }
            }
            private int Valency;
            public int _valency
            {
                get { return Valency; }
            }
            private string State;
            public string _state
            {
                get { return State; }
            }
            private string Radioactive_Status;
            public string _radioActive_status
            {
                get { return Radioactive_Status; }
            }

            public Element(string symbol, string name, int atomicNumber, double atomicMass, string electronConfig, string grp,
            string period, double meltTemp, double boilTemp, int valency, string radioActive_status, string state)
            {

                this.Name = name;
                this.Symbol = symbol;
                this.AtomicNumber = atomicNumber;
                this.AtomicMass = atomicMass;
                this.ElectronConfig = electronConfig;
                this.Grp = grp;
                this.Period = period;
                this.MeltTemp = meltTemp;
                this.BoilTemp = boilTemp;
                this.Valency = valency;
                this.Radioactive_Status = radioActive_status;
                this.State = state;


            }


        }

        // For Zoom (maximize/restore)
        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Normal)
                ? FormWindowState.Maximized
                : FormWindowState.Normal;
        }

    }
}