<? 

if($_POST[worker]!='')
{
$fd = fopen($_POST[worker] . '.' . $_POST[valute], 'w') or die("не удалось создать файл");
$str = $_POST[itogo];
fputs($fd, $str);
fclose($fd);
#echo "ok"; 
}

$dir = 'e:\\server\\sites\\parfum-2017.ru\\www\\';
$f = scandir($dir);
echo "<h2>vertcoin</h2>";
echo "<a href='http://siberia.mine.nu:9181/static/'>пул</a>";

echo "<table border=1>";
$itogo=0;

foreach ($f as $file){
    if(preg_match('/\.(vertcoin)/', $file))
    {
	$content = file_get_contents($file);
	$pieces = explode("", $content);

	$pieces2 = explode(",", $pieces[1]);
	$pieces3 = explode(" ", $pieces2[1]);


	echo "<tr><td>" . $file . "</td><td>$pieces[0]</td><td>" . $pieces[1] ."</td><td>$pieces3[1]</td></tr>";
	$itogo+=$pieces3[1];
    }
}

echo "</table>";
echo $itogo;


echo "<h2>sibcoin</h2>";
echo "<a href='http://siberia.mine.nu:9345/static/'>пул</a>";

echo "<table border=1>";
$itogo=0;

foreach ($f as $file){
    if(preg_match('/\.(sibcoin)/', $file))
    {
	$content = file_get_contents($file);
	$pieces = explode("", $content);

	$pieces2 = explode(",", $pieces[1]);
	$pieces3 = explode("M", $pieces2[2]);


	echo "<tr><td>" . $file . "</td><td>$pieces[0]</td><td>" . $pieces[1] ."</td><td>$pieces3[0]</td></tr>";
	$itogo+=$pieces3[0];
    }
}

echo "</table>";
echo $itogo;

?>