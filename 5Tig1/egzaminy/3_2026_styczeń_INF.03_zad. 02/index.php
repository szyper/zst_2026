<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        $connection = mysqli_connect("localhost", "root", "", "bazar");

        $query = "SELECT towar.nazwa, towar.plik FROM towar LIMIT 10";

        $result = mysqli_query($connection, $query);

        while($row = mysqli_fetch_assoc($result)){
            echo "<img src='PlikiSt202602/{$row['plik']}' alt='{$row['nazwa']}'>";
        }
    ?>
    
</body>
</html>