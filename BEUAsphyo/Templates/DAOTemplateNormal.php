<?php
	/**
	* This class contain all methods to interact with the data base
	* @author lHersey
	* @GitHub http://Github.com/lHersey
	* @GitHub http://Github.com/lHersey
	*/
require_once(__DIR__ . '/../Domain/{{TableName}}.php');
require_once(__DIR__ . '/../Databases/MySQL.php');

class {{TableName}}DAO extends {{DATABASE_ENGINE}}{

	public function __construct(){}

	/****************************************************
		* this method add a new {{TableName}} in the data base  * 
	****************************************************/

	public function Add({{TableName}} $o{{TableName}}){
		$STMT = parent::PREPARE('{{INSERT_TABLE}}');
		{{ParametersInsert}}
			return parent::CMD($STMT);
    }

	public function Update({{TableName}} $o{{TableName}}){
		$STMT = parent::PREPARE('{{UPDATE_TABLE}}');
		{{ParametersUpdate}}
		return parent::CMD($STMT);
	}

	public function Delete({{TableName}} $o{{TableName}}){
		$STMT = parent::PREPARE('{{DELETE_TABLE}}');
		{{ParametersDelete}}
		return parent::CMD($STMT);
	}

	public function SelectUnique({{TableName}} $o{{TableName}}){
		$STMT = parent::PREPARE('{{SELECT_UNIQUE_TABLE}}');
		{{ParametersSelectUnique}}
		return parent::FirstOrDefault($STMT);
	}

	public function SelectAll(){
		$STMT = parent::PREPARE('{{SELECT_ALL_TABLE}}');
		return parent::SELECT($STMT);
	}

	public function Exists({{TableName}} $o{{TableName}}){
		$STMT = parent::PREPARE('{{EXISTL_TABLE}}');
		return parent::FirstOrDefault($STMT)->Count() > 0;
	}
}

?>