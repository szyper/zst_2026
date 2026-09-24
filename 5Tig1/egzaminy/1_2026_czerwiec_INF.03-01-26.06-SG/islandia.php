<?php
    // połączenie z bazą danych
    $conn = mysqli_connect("localhost", "root", "", "zst_islandia_5ti");

    // sprawdzenie połączenia
    if (!$conn) {
        die("Błąd połączenia z bazą danych");
    }

    // ustawienie kodowania znaków
    mysqli_set_charset($conn, "utf8");

    // skrypt 1 - zapytanie 3
    $query3 = "SELECT obiekty.nazwa FROM obiekty WHERE obiekty.idRodzaj = 10 AND obiekty.panstwo = 'Islandia'";
    $result3 = mysqli_query($conn, $query3);

    // skrypt 2 - zapytanie 2
    $query2 = "SELECT obiekty.nazwa FROM obiekty WHERE obiekty.idRodzaj = 14 AND obiekty.panstwo = 'Islandia'";
    $result2 = mysqli_query($conn, $query2);

    // skrypt 3 - zapytanie 1
    $query1 = "SELECT obiekty.idObiekt, obiekty.plik, obiekty.nazwa FROM `obiekty` WHERE obiekty.panstwo = 'Islandia'";
    $result1 = mysqli_query($conn, $query1);


?>
<!doctype html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Islandia</title>
    <link rel="stylesheet" href="styl.css">
</head>
<body>
    <header>
        <h1>
            <a href="islandia.php">Zwiedzaj Islandię</a>
        </h1>
    </header>
    <aside>
        <h3>Do zwiedzania</h3>
        <ul>
            <li>
                Wodospady:
                <ol>
                    <?php
                        while($row = mysqli_fetch_assoc($result3)){
                            echo "<li>".$row["nazwa"]."</li>";
                        }
                    ?>
                </ol>
            </li>
            <li>
                Siedliska zwierząt:
                <ol>
                    <?php
                        while($row = mysqli_fetch_assoc($result2)) {
                            echo "<li>". $row["nazwa"]. "</li>";
                        }
                    ?>
                </ol>
            </li>
        </ul>
    </aside>

    <main>
        <h2>Galeria</h2>
        <section>
            <?php
                // wyświetlenie wszystkich obiektów z Islandii
                while($row = mysqli_fetch_assoc($result1)) {
                    echo "
                        <a href='obiekty.php?id={$row["idObiekt"]}'>
                            <img 
                                src='{$row["plik"]}'
                                alt='{$row["nazwa"]}'
                                title='{$row["nazwa"]}'
                                class='miniatura'
                        </a>
                    ";
                }
            ?>
        </section>
    </main>
    
</body>
</html>
