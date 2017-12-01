<?php
namespace src\Model\Domain{
		/**
		* This class contain all attributes for the model of the table {{TableName}}
		* @author lHersey
		* @GitHub http://github.com/lHersey
		*/
	class {{TableName}}{
		//Attributes
		{{ModelAtributes}}

		//Constructors
		public static function createNull{{TableName}}(){
			$instance = new self();
			return $instance;
		}


		public static function create{{TableName}}({{ParametersConstructor}}){
			$instance = new self();
            {{InsideConstructor}}
			return $instance;
		}

		{{Propiertes}}

		public function toJSON(){
			{{TOJSON}}
			return json_encode($array{{TableName}});
		}
	}
}
?>