Imports Northwind.DataAccessLayer

Module Module1

    Sub Main()

        Using dbContext As New NorthwindDbContext()

            Dim categories = dbContext.Categories

            For Each category In categories
                Console.WriteLine(category.CategoryId & " " & category.CategoryName)
            Next

            Console.WriteLine()

            Dim customerHistories = dbContext.CustOrderHist("ALFKI")

            For Each customerHistory In customerHistories
                Console.WriteLine($"{customerHistory.Total,2} {customerHistory.ProductName}")
            Next


            Dim orderDetail = dbContext.OrderDetails.First()
            Console.WriteLine(orderDetail.Product.ProductName)

            Console.WriteLine()

            Console.WriteLine(dbContext.GetSaveChangesCount())
            dbContext.SaveChanges()
            dbContext.SaveChanges()
            Console.WriteLine(dbContext.GetSaveChangesCount())

            Dim newTables = dbContext.Database.SqlQuery(Of NewTable)("select * from NewTable")

            For Each newTable In newTables
                Console.WriteLine($"id: {newTable.Id}   name: {newTable.Name}   desc: {newTable.Desc}   datetime: {newTable.NewField}")
            Next

            ' Update Table: NewTable
            Dim efNewTables = dbContext.NewTables

            For Each efNewTable In efNewTables
                efNewTable.NewField = DateTime.Now
            Next

            ' save changes
            dbContext.SaveChanges()

            newTables = dbContext.Database.SqlQuery(Of NewTable)("select * from NewTable")

            For Each newTable In newTables
                Console.WriteLine($"id: {newTable.Id}   name: {newTable.Name}   desc: {newTable.Desc}   datetime: {newTable.NewField}")
            Next

        End Using

        Console.WriteLine("Press any key to exit....")
        Console.ReadKey()
    End Sub

End Module
