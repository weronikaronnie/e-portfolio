<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Music Library</title>
            <style>
                body {
                    padding: 1rem;
                }
            </style>
    </head>
    <body>
        <h1>Music Library</h1>
        <?php
        // Creating XML document representing music library songs
        $musicLibrary = new SimpleXMLElement('<musicLibrary></musicLibrary>');
        $song1 = $musicLibrary->addChild('Song');
        $song1->addAttribute('ID', '1');
        $song1->addChild('Name', 'Call My Name');
        $song1->addChild('Artist', 'J&apos;Calm');

        $song2 = $musicLibrary->addChild('Song');
        $song2->addAttribute('ID', '2');
        $song2->addChild('Name', 'Shivering');
        $song2->addChild('Artist', 'ILLENIUM, Spiritbox');

        $song3 = $musicLibrary->addChild('Song');
        $song3->addAttribute('ID', '3');
        $song3->addChild('Name', 'Ain&apos;t It Fun');
        $song3->addChild('Artist', 'Paramore');

        // Querying and displaying music library songs
        $songs = $musicLibrary->xpath('//Song');
        foreach ($songs as $song) {
            echo "ID: " . $song['ID'] . "<br><br>";
            echo "Name: " . $song->Name . "<br><br>";
            echo "Artist: " . $song->Artist . "<br><br>";
            echo "<br><br>";
        }
        ?>
    </body>
</html>
