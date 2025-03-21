export type User = {
    id: number
    name: string
    email: string
    phone: string 
    isLogged?: boolean  
}
export const users: User[] = [
    {
        id: 1,
        name: "John Doe",
        email: "john.doe@example.com",
        phone: "123-456-7890",
        isLogged: false
    },
    {
        id: 2,
        name: "Jane Smith",
        email: "jane.smith@example.com",
        phone: "234-567-8901",
        isLogged: true
    },
    {
        id: 3,
        name: "Alice Johnson",
        email: "alice.johnson@example.com",
        phone: "345-678-9012",
        isLogged: true
    },
    {
        id: 4,
        name: "Bob Brown",
        email: "bob.brown@example.com",
        phone: "456-789-0123",
        isLogged: true
    },
    {
        id: 5,
        name: "Charlie Davis",
        email: "charlie.davis@example.com",
        phone: "567-890-1234",
        isLogged: false
    },
    {
        id: 6,
        name: "Diana Evans",
        email: "diana.evans@example.com",
        phone: "678-901-2345",
        isLogged: true
    },
    {
        id: 7,
        name: "Evan Harris",
        email: "evan.harris@example.com",
        phone: "789-012-3456",
        isLogged: false
    },
    {
        id: 8,
        name: "Fiona Green",
        email: "fiona.green@example.com",
        phone: "890-123-4567",
        isLogged: true
    },
    {
        id: 9,
        name: "George Hill",
        email: "george.hill@example.com",
        phone: "901-234-5678",
        isLogged: true
    },
    {
        id: 10,
        name: "Hannah White",
        email: "hannah.white@example.com",
        phone: "012-345-6789",
        isLogged: true
    }
]