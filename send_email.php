<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Get form data
    $name = $_POST["name"];
    $email = $_POST["email"];
    $message = $_POST["message"];
    $website = $_POST["website"];

    // Validate the form data (you can add your own validation logic here)

    // Prepare email content
    $subject = "New Contact Form Submission";
    $body = "Name: $name\nEmail: $email\nMessage: $message";

    // Set the recipient email address
    $to = "arieljordz@gmail.com";

    // Set additional email headers
    $headers = "From: $email";

    // Send the email
    $success = mail($to, $subject, $body, $headers);

    if ($success) {
        // Email sent successfully
        echo "Thank you for your message. We'll be in touch shortly.";
    } else {
        // Error sending email
        echo "Sorry, there was a problem sending your message. Please try again later.";
    }
}
?>
