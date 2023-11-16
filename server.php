<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
  $data = json_decode(file_get_contents("php://input"), true);
  
  // Success Message
  $response = array("message" => "Task added successfully");
  echo json_encode($response);
}
?>
