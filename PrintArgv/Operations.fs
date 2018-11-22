module Operations

open Domain


let getInitials customer =
    customer.FirstName.Substring(0, 1), customer.LastName.Substring(0, 1)


let t =  { FirstName = "Terrence"; LastName = "Brannon"; Age = 50 }
let i = getInitials t
