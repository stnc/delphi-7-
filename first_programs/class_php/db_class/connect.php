<?php

abstract class Database
{

	const DB_HOST = 'localhost';
	const DB_NAME = 'test';
	const DB_USER = 'root';
	const DB_PWD = '123456';

	abstract protected function connect();

	abstract protected function disconnect();

}

class mySQL extends Database
{
	protected $_connection;

	public function __construct()
	{

		$this->connect();

	}

	protected function connect()
	{

		$this->_connection = mysql_connect(self::DB_HOST, self::DB_USER, self::DB_PWD);
		mysql_select_db(self::DB_NAME, $this->_connection);

	}

	protected function disconnect()
	{
		return @mysql_close($this->_connection);

	}

	public function __destruct()
	{
		$this->disconnect();

	}

	protected function query($query)
	{

		if($results = mysql_query($query, $this->_connection)) {

			$rows = array();

			while($result = mysql_fetch_array($results)) {

				$rows[] = $result;

			}

			return $rows;

		} else {

			return mysql_error($this->_connection);

		}

	}

}


class Displayer extends mySQL
{
	public function __construct()
	{
		parent::__construct();

	}

	public function display($queryResults)
	{

		$results = $this->query($queryResults);
		$html = '';

		foreach($results as $result) {

			$html .= '<p>' . $result['user_email'] . '</p>' . "\n";//bnu indis olarak ver

		}

		return $html;

	}

}

	$displayer = new Displayer();
	$query = "select * from users";

	echo $displayer->display($query);


