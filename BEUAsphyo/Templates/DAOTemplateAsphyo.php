<?php
namespace Asphyo\src\Model\DAO{
		/**
		* This class contain all methods to interact with the data base
		* @author lHersey
		* @GitHub http://Github.com/lHersey
		*/
	use Asphyo\bin\Model\Databases\MySQL;
	use Asphyo\src\Model\Domain\{{TableName}};
	class {{TableName}}DAO extends MySQL{

		//Add a {{TableName}}
		public function Add({{TableName}} $o{{TableName}}){
			$STMT = parent::PREPARE('{{INSERT_TABLE}}');
			{{ParametersInsert}}
			return parent::CMD($STMT);
		}

		//Update a {{TableName}}
		public function Update({{TableName}} $o{{TableName}}){
			$STMT = parent::PREPARE('{{UPDATE_TABLE}}');
			{{ParametersUpdate}}
			return parent::CMD($STMT);
		}

		//Delete a {{TableName}}
		public function Delete({{TableName}} $o{{TableName}}){
			$STMT = parent::PREPARE('{{DELETE_TABLE}}');
			{{ParametersDelete}}
			return parent::CMD($STMT);
		}

		//Select one {{TableName}}
		public function SelectByPrimaryKey({{TableName}} $o{{TableName}}){
			$STMT = parent::PREPARE('{{SELECT_UNIQUE_TABLE}}');
			{{ParametersSelectUnique}}
			return parent::FirstOrDefault($STMT);
		}

		//Select all {{TableName}}
		public function SelectAll(){
			$STMT = parent::PREPARE('{{SELECT_ALL_TABLE}}');
			return parent::SELECT($STMT);
		}

		//Varify if a {{TableName}} exist
		public function Exists({{TableName}} $o{{TableName}}){
			$STMT = parent::PREPARE('{{EXISTL_TABLE}}');
			{{ParametersExists}}
			return parent::FirstOrDefault($STMT)->Count() > 0;
		}
	}
}
?>