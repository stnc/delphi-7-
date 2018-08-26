<?php
abstract class employee
{
	protected $empname;
	protected $empage;

	function setdata($empname,$empage)
	{
		$this->empname = $empname;
		$this->empage = $empage;
	}

	abstract function outputData();
}

abstract class EmployeeData extends employee
{
	abstract function setDataForEmployee();
}

class Payment extends EmployeeData
{
	function setDataForEmployee()
	{
		//Functionality
	}

	function outputData()
	{
		echo "Inside Payment Class";
	}
}

$a = new Payment();
$a->outputData();
