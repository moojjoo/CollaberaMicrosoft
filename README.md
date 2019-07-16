# CollaberaMicrosoft
Collabera Questions to be answered to get Microsoft Interview

#Robert B. Dannelly, Jr.

# All answers inside CollaberaMicrosoft.sln


1. ConvertToNumber - ConvertToNumber.cproj
2. Increment & Decrement – Find The Bugs! - IncrementDecrement.csproj
3. Mystery Method - MysteryMethod.csproj
4. Sort Products by Priority - SortProductsbyPriority.csproj
5. Generate Lowest Number - GenerateLowestNumberQuestion.csproj - **RBD This was tough, thank you for the challange**
6. SQL Questions

    1. Provide a list of customers who have ever purchased
    ```
        SELECT DISTINCT c.LastName, c.FirstName FROM Customer c RIGHT JOIN [Order] o 
        ON c.CustomerID = o.CustomerID
    ```
    2. What date was the most expensive order placed and which customer placed it.
    ```
        --What date was the most expensive order placed and which customer placed it.

        SELECT TOP(1) o.OrderDate, c.LastName, c.FirstName, SUM(li.ItemPrice) AS GreatestOrder FROM Customer c 
        INNER JOIN [Order] o ON c.CustomerID = o.CustomerID
        INNER JOIN LineItem li ON o.OrderID = li.OrderID
        GROUP BY o.OrderDate, c.LastName, c.FirstName, li.ItemPrice
        Order By GreatestOrder DESC
    ```

       


