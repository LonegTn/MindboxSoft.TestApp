SELECT Product.Name, Category.Name FROM Product
LEFT JOIN Product_Category ON Product_Category.Product_Id = Product.Id
LEFT JOIN Category ON Product_Category.Category_Id = Category.Id