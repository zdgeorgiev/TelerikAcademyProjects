# Defining Classes Part One

## Tasks discriptions:

1. Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors). Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
2. Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it). Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
3. Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
4. Add a method in the GSM class for displaying all information about it. Try to override ToString().
5. Use properties to encapsulate the data fields inside the GSM, Battery and Display classes. Ensure all fields hold correct data at any given time.
6. Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
7. Write a class GSMTest to test the GSM class:
  - Create an array of few instances of the GSM class.
  - Display the information about the GSMs in the array.
  - Display the information about the static property IPhone4S.
8. Create a class Call to hold a call performed through a GSM. It should contain date, time, dialed phone number and duration (in seconds).
9. Add a property CallHistory in the GSM class to hold a list of the performed calls. Try to use the system class List<Call>.
10. Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.
11. Add a method that calculates the total price of the calls in the call history. Assume the price per minute is fixed and is provided as a parameter.
12. Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
  - Create an instance of the GSM class.
  - Add few calls.
  - Display the information about the calls.
  - Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
  - Remove the longest call from the history and calculate the total price again.
   Finally clear the call history and print it.
  - 
  BONUS:
  - 
1.      Дефинирайте клас Student, който съдържа следната информация за студентите: трите имена, курс, специалност, университет, електронна поща и телефонен номер.
2.      Декларирайте няколко конструктора за класа Student, които имат различни списъци с параметри (за цялостната информация за даден студент или част от нея). Данните, за които няма входна информация да се инициализират съответно с null или 0.
3.      Добавете статично поле в класа Student, в което се съхранява броя на създадените обекти от този клас.
4.      Добавете метод в класа Student, който извежда пълна информация за студента.
5.      Модифицирайте текущия код на класа Student така, че да капсулирате данните в класа чрез свойства.
6.      Напишете клас StudentTest, който да тества функционалността на класа Student.
7.      Добавете статичен метод в класа StudentTest, който създава няколко обекта от тип Student и ги съхранява в статични полета. Създайте статично свойство на класа, което да ги достъпва. Напишете тестова програма, която да извежда информацията за тях в конзолата.
