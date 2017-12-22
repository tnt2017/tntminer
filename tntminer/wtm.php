<? 

$vertcoin="vertcoin\n" . "ccminer-x64.exe\n" . " -a lyra2v2 -o stratum+tcp://siberia.mine.nu:9181 -u VwXCETy8iN1btYctoksKibmoHs6yAZGqEg -p c=CREA,stats --cpu-priority 3"; 
$sibcoin= "sibcoin\n" .  "ccminer_Alex_v1_x64-sib-cuda8.exe\n" . " -a sib -o stratum+tcp://siberia.mine.nu:9345 -u SRj2HAtAoqnxGE8MZTnTfMExU6wGasATpx -p x"; 
$monacoin="monacoin\n" . "ccminer-x64.exe\n" . " -a lyra2v2 -o stratum+tcp://crypto.mine.nu:2942 -u VwXCETy8iN1btYctoksKibmoHs6yAZGqEg -p c=CREA,stats --cpu-priority 3";
$zcash="zcash\n" . "ccminer-x64.exe\n" . " -a equihash -o stratum+tcp://eu1-zcash.flypool.org:3333 -u t1Tzb9vdABkyuzT6WhR4j3LwapbBQzQHSmA -p c=CREA,stats --cpu-priority 3";

if($_POST[worker]!='')
{
   if($_POST[worker]=='F1060' || $_POST[worker]=='SERVER16')
   {
	echo $vertcoin;
   }
   if($_POST[worker]=='PODSTOLOM' || $_POST[worker]=='990FX')
   {
   	#echo $sibcoin;
	echo $vertcoin;
   }
   if($_POST[worker]=='PAPA' || $_POST[worker]=='F1080')
   {
   	#echo $sibcoin;
	echo $vertcoin;
   } 
   if($_POST[worker]=='DESKTOP-02VCM6R')
   {	
	echo $zcash;
	echo $vertcoin;
   }

}

?>