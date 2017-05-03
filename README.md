# Sales-tracker
## Created By Elise and Shruti

####Description

####User Stories




**perform the following actions on a single page using AJAX.**
**Be sure to write unit tests for all of your actions. This is a good opportunity to practice using a mock database or a test database.**

**see inventory AND costs for inventory items**
* Create car model
* Create carsController
* Perform migrations to create car table in database
* Seed database with cars
* List cars with Ajax

**add new inventory for sale, including item cost and sale price**
* add a car

**View sales**
* Create sale model
* Create SalesController
* Update database with migration
* Seed the database with sales?
* List sales with Ajax


**see the total balance sheet for the entire store (revenue - costs = profit)**
* Create a table (or maybe something else? Ask John?) that keeps track of the balance sheet
* Use list of sales to generate final numbers


**view sales associate comments on sales**
* Click on a sales to see the details, including comments (with AJAX)

**review and edit sales by all sales associates, to correct for errors**
* Add edit functionality (with AJAX)

**make a sale, which reduces inventory and increases revenue**
* Add create functionality for sales
* Make sure that each created sale reduces inventory and increases revenue

**process a return which returns an item to inventory and credits a refund**
* Create a way to return items in the sale(int? bool - since it's a car and not a pie?)

**add or remove sales associate**
* Create associate model
* Create AssociateController
* Edit database with migration
* Add create functionality for associates


**calculate my commission based on my individual sales**
* add commission to associate (calculate based on their sales)

**see commission for all sales associates**
* add to balance sheet



**Login as a sales associate or a manager.**
**Sales associate role**
*View cars*
*see complete inventory to help customers*
*create sale*
*comment on sales*
*see all of my sales, and make comments that only I can see**
* Be able to edit their own sales



**Manager role**
*See the sales report and sales commission for every associate
*See all details of sales (including comments)
*add or remove sales associate
*see commission for all sales associates
