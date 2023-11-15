<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Bill Tracker</title>
    </head>
    <style>
            body {
                padding: 1rem;
            }
            h2 {
                margin-bottom: 10px;
            }
        </style>
    <body>
        <h2>Bill Tracker</h2>
        <?php
        // Bill Tracker
        $billTracker = array(
            array("name" => "Rent", "price" => 1500, "next payment" => "26 December 2023"),
            array("name" => "Car", "price" => 350, "next payment" => "17 December 2023"),
            array("name" => "Phone", "price" => 87, "next payment" => "4 December 2023")
           );
        
        // Serializing to JSON
        $jsonData = json_encode($billTracker);
        
        // Displaying serialized JSON
        echo "<h3>Serialized JSON:\n</h3>";
        echo $jsonData;
        echo "<br><br>";
        
        // Deserializing JSON to PHP array
        $decodedData = json_decode($jsonData, true);
        
        // Displaying deserialized JSON
        echo "<h3>Deserialized JSON: \n</h3>";
        print_r($decodedData);
        ?>
    </body>
</html>
