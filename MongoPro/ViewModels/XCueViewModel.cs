using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoPro.ViewModels
{
    public class XCueViewModel:ViewModelBase
    {
		private BindingList<ScriptCommand> _scriptCommandsDt = new BindingList<ScriptCommand>(){
            new ScriptCommand(){ID = 1,ParentID = 0,Name = "Sequential"},
            new ScriptCommand(){ID = 2,ParentID = 1,Name = "SEQUENTIAL_MATH"},
            new ScriptCommand(){ID = 3,ParentID = 1,Name = "SEQUENTIAL_THRESHOLD"},

			 new ScriptCommand(){ID = 10,ParentID = 0,Name = "Standard"},
			 new ScriptCommand(){ID = 11,ParentID = 10,Name = "CALL"},
			 new ScriptCommand(){ID = 12,ParentID = 10,Name = "CALL_TABLE"},
			 new ScriptCommand(){ID = 13,ParentID = 10,Name = "DO"},
			 new ScriptCommand(){ID = 14,ParentID = 10,Name = "DO WHILE"},
			 new ScriptCommand(){ID = 15,ParentID = 10,Name = "ELSE"},
			 new ScriptCommand(){ID = 16,ParentID = 10,Name = "END"},
			 new ScriptCommand(){ID = 17,ParentID = 10,Name = "END_IF"},
			 new ScriptCommand(){ID = 18,ParentID = 10,Name = "EQUATION"},
			 new ScriptCommand(){ID = 19,ParentID = 10,Name = "EXIT"},
			 new ScriptCommand(){ID = 20,ParentID = 10,Name = "IF THEN"},
			 new ScriptCommand(){ID = 21,ParentID = 10,Name = "JUMP"},
			 new ScriptCommand(){ID = 22,ParentID = 10,Name = "LABEL"},
			 new ScriptCommand(){ID = 23,ParentID = 10,Name = "MESSAGE_BOX"},
			 new ScriptCommand(){ID = 24,ParentID = 10,Name = "PRINT"},
			 new ScriptCommand(){ID = 25,ParentID = 10,Name = "SET_TO_CURRENT_TIME"},
			 new ScriptCommand(){ID = 26,ParentID = 10,Name = "STEP_TIME"},
			 new ScriptCommand(){ID = 27,ParentID = 10,Name = "WAIT"},
			 new ScriptCommand(){ID = 28,ParentID = 10,Name = "WAIT_UNTIL"},
			 new ScriptCommand(){ID = 29,ParentID = 10,Name = "\\{COMMENT}"},

			 new ScriptCommand(){ID = 40,ParentID = 0,Name = "String Support"},
			 new ScriptCommand(){ID = 41,ParentID = 40,Name = "CONCATENATE"},
			 new ScriptCommand(){ID = 42,ParentID = 40,Name = "SCRIPT_STOP"},
			 new ScriptCommand(){ID = 43,ParentID = 40,Name = "SCRIPT_RUN"},
			 new ScriptCommand(){ID = 44,ParentID = 40,Name = "SCRIPT_1"},
			 new ScriptCommand(){ID = 45,ParentID = 40,Name = "SCRIPT_2"},
			 new ScriptCommand(){ID = 46,ParentID = 40,Name = "SCRIPT_3"},
			 new ScriptCommand(){ID = 47,ParentID = 40,Name = "SCRIPT_4"},
			};

		public BindingList<ScriptCommand> ScriptCommandsDt
		{
			get { return _scriptCommandsDt; }
			set { 
				_scriptCommandsDt = value; 
				}
		}

		private BindingList<FileInfo> _fileInfos = new BindingList<FileInfo>(){ 
				new FileInfo(){LoadedFiles = "Sub_do_Temp",Type = "Script",Directory = "JC\\New folder"},
				new FileInfo(){LoadedFiles = "888",Type = "Script",Directory = "."},
				new FileInfo(){LoadedFiles = "H2P-S-MGX",Type = "Script",Directory = "H2P"},
				new FileInfo(){LoadedFiles = "H3P-S-MGX",Type = "Script",Directory = "H2P"},
				new FileInfo(){LoadedFiles = "H4P-S-MGX",Type = "Script",Directory = "H2P"},
			};

		public BindingList<FileInfo> FileInfos
		{
			get { return _fileInfos; }
			set { _fileInfos = value; }
		}

        private BindingList<RowInfo> _rowInfo;

        public BindingList<RowInfo> RowInfos
        {
            get { return _rowInfo; }
            set { _rowInfo = value; }
        }

        private BindingList<ScriptState> _scriptState = new BindingList<ScriptState>{ 
				new ScriptState(){ScriptStatement="SET VALUE\n" +
					"  V_current_density_request= 2.200\n" +
					"  V_anode_pressure_set = 180.00\n" +
					"  V_cathode_pressure set = 160.00\n" +
					"  V_anode_stoich_set= 1.50\n" +
					"  V_cathode_ stoich_set = 2.20\n" +
					"  V anode dew set= 61.00\n" +
					"  V_cathode_dew_set= 46.00\n" +
					"  V_coolant temp_in_set= 71.00\n" +
					"  V_coolant temp_out set= 82.00\n" +
					"  flow_coolant_set= 2.80\n" +
					"  scattergraph_sample_size = 30.00\n" +
					"END SET"},
                new ScriptState(){ScriptStatement="CALL JC\\New folder\\Sub_do_Temp.aut"},
                new ScriptState(){ScriptStatement="CALL JC\\New folder\\Sub_do_Pressure.aut"},
                new ScriptState(){ScriptStatement="CALL JC\\New folder\\Sub_do_current.aut"},
                new ScriptState(){ScriptStatement="WAIT_UNTIL temp_anode_dewpoint_gas = temp_anode_dewpoint_set TOLERANCE =2\n" +
					"  AND temp_anode_inlet = temp_anode_gas_inlet_set TOLERANCE =5\n" +
					"  AND temp_cathode_dewpoint_gas = temp_cathode_dewpoint_set TOLERANCE = 2\n" +
					"  AND temp_cathode_inlet = temp_cathode_gas_inlet_set TOLERANCE = 5\n" +
					"  AND temp_coolant_outlet = temp_coolant_set TOLERANCE = 2\n" +
					"END_WAIT"},
                new ScriptState(){ScriptStatement="WAIT 150 sec"},
                new ScriptState(){ScriptStatement="SET_STRING scattergraph_test_name \"MGX\""},
			};

        public BindingList<ScriptState> ScriptStates
        {
            get { return _scriptState; }
            set { _scriptState = value; }
        }
	}

	public class ScriptCommand
	{
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string Name { get; set; }
	}

	public class FileInfo
	{
		public string LoadedFiles { get; set; }
		public string Type { get; set; }
		public string Directory { get; set; }
	}

	public class RowInfo
	{
        public string RowNo { get; set; }
        public string ErrorDescription { get; set; }
	}

    public class ScriptState
    {
        public string ScriptStatement { get; set; }
    }
}
