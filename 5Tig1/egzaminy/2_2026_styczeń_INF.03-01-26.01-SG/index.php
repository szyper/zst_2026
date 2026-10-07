<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <title>Tytuł strony</title>
		<link rel="stylesheet" href="./styl.css">
</head>
<body>
<?php
	$conn = mysqli_connect("localhost", "root",
    "", "samochody");

	$result = mysqli_query($conn, "SELECT pojazdy.marka, pojazdy.model, pojazdy.cena, pojazdy.cena + kolory.doplata AS 'Cena całkowita', kolory.nazwa, kolory.doplata FROM `pojazdy` INNER JOIN kolory ON pojazdy.kolor=kolory.id WHERE model = 'alfa'");

	echo "<table>
					<tr>
						<th>Marka</th>   
						<th>Model</th>   
						<th>Cena</th>   
						<th>Cena całkowita</th>   
					";
	while ($row = mysqli_fetch_assoc($result)) {
		echo "<tr>";
			echo "<td>" . $row['marka'] . "</td>";
			echo "<td>" . $row['model'] . "</td>";
			echo "<td>" . $row['cena'] . "</td>";
			echo "<td>" . $row['Cena całkowita'] . "</td>";
		echo "</tr>";
	}
	echo "</table><hr>";

	$sql = "SELECT pojazdy.marka, pojazdy.model, pojazdy.cena FROM `pojazdy` ORDER BY RAND() LIMIT 2;";

	$result = mysqli_query($conn, $sql);
?>

	<div class="konfigurator">
		<div class="naglowek">
			<div>Konfiguracja</div>
			<div>Cena</div>
		</div>

		<?php
			while ($row = mysqli_fetch_assoc($result)) {
				echo "<div class='pojazd'>";
					echo '<img src="./inf03-2026-styczen-egzamin-zawodowy-praktyczny-zalaczniki/pliki1/a1.jpg" alt="Auto">';

					echo "<div class='informacje'>";
						echo "<div class='wiersz'>";
							echo "<span>Marka</span>";
							echo "<span>cena".$row['marka']."</span>";
							echo "<span>".$row['cena']."</span>";
						echo "</div>";
						echo "<div class='wiersz'>";
							echo "<span>Model</span>";
							echo "<span>cena".$row['model']."</span>";
						echo "</div>";
					echo "</div>";
				echo "</div>";
			}
		?>

	</div>
</body>
</html>