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

        // skrypt 1
        $query = "SELECT towar.nazwa, towar.plik FROM towar LIMIT 10";

        $result = mysqli_query($connection, $query);

        while($row = mysqli_fetch_assoc($result)){
            echo "<img src='PlikiSt202602/{$row['plik']}' alt='{$row['nazwa']}'>";
        }

        // skrypt 2
        
    ?>

    <form method="post">
        <select name="product">
            <?php
                $query = "SELECT towar.id, towar.nazwa FROM towar";
                $result = mysqli_query($connection, $query);

                while ($row = mysqli_fetch_array($result)) {
                    echo "<option value=\"$row[id]\">$row[nazwa]</option>";
                }
            ?>
            
        </select>
        <input type="number" name="weight">
        <button type="submit">Zamów</button>
    </form>

    <?php
                if (isset($_POST["product"]) && isset($_POST["weight"])) {
                    $id = (int) $_POST["product"];
                    $weight = (int) $_POST["weight"];

                    $query = "SELECT towar.rodzaj, towar.nazwa, towar.cena FROM towar WHERE towar.id = $id";

                    $result = mysqli_query($connection, $query);

                    if ($row = mysqli_fetch_array($result)) {
                        $value = $row["cena"] * $weight;

                        echo "<p>{$row['rodzaj']} {$row['nazwa']} wartość: $value zł</p>";

                    }
                }
    ?>
</body>
</html>