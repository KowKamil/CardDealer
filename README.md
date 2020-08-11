# CardDealer
CardDealer is a simple .NET Core MVC project that deals with dealing playing cards. 

# Instructions
You can use the following routes and parameters to customize your request:
* /card/
  * /index
    * amount - How many cards to draw? Value: between 1 and 100000, default: 1;
    * sorted - Should the cards be sorted in ascending order? Value: true or false, default: false;
    * repeats - Should cards be returned to the deck after pulling them? Value true or false, default: false;
* /help - displays instructions similar to this paragraph
