# Restocking-Fee
This is an application designed to quickly take the item price and return the amount the customer gets back minus a restocking fee. The application is currently set to take 10% as a restocking fee. The user can input the price of the item by pasting it from the clipboard with the paste button or typing it into the input text form. The user can also copy the output value onto their clipboard with the copy button.

The application currently validates the input when the user presses the paste button. If the input is a valid number the button will turn green then fade to white else the button will turn red and fade to white.

### Examples
![Successfully parsing from clipboard](/Example%20Images/PasteSuccess.gif)

An example of pasting a number from the clipboard into the application

![Failing to parse from clipboard](/Example%20Images/PasteFail.gif)

An example of attempting to paste when the clipboard has the value "test" or an image

![Typing in the number](/Example%20Images/TextInput.gif)

Typing in the number 120 into the input box
