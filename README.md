# CarevecMobile

Тема: Продажба на мобилни телефони и предлагане на мобилни пакети.
 
+ администратор - CRUD телефоните / CRUD пакети
+ потребител - Да си взема услуги / телефони
+ гест - само ще разглежда сайта

## Database Models
User
-Phones
-ServicePackage


Roles -> Admin, BaseUser

User
- Phones<PhoneUserMapping> - list, array
- ServicePackages - list, array

Phone
- Id - int
- Model - string
- ImageUrl - string
- Price - decimal
- Brand - string
- Year - DateTime
- Description - string
-Users<PhoneUserMapping> - list, array

PhoneUserMapping
- UserId - string
- PhoneId - int

ServicePackage
- Id - int
- Description - string
- Name - string
- Price - decimal
- DurationTime - DateTime
- UserId
