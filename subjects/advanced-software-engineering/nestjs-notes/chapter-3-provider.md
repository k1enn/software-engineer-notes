# Chapter 3 Provider

Create a service using CLI

```cli
nest g service users`
```

Our complete`users.service.ts`:

```ts
import { Injectable } from '@nestjs/common';

@Injectable()
export class UsersService {
  private users = [
    {
      id: 1,
      name: 'Leanne Graham',
      email: 'Sincere@april.biz',
      role: 'INTERN',
    },
    {
      id: 2,
      name: 'Ervin Howell',
      email: 'Shanna@melissa.tv',
      role: 'INTERN',
    },
    {
      id: 3,
      name: 'Clementine Bauch',
      email: 'Nathan@yesenia.net',
      role: 'ENGINEER',
    },
    {
      id: 4,
      name: 'Patricia Lebsack',
      email: 'Julianne.OConner@kory.org',
      role: 'ENGINEER',
    },
    {
      id: 5,
      name: 'Chelsey Dietrich',
      email: 'Lucio_Hettinger@annie.ca',
      role: 'ADMIN',
    },
  ];

  findAll(role?: 'INTERN' | 'ENGINEER' | 'ADMIN') {
    if (role) {
      return this.users.filter((user) => user.role === role);
    }

    return this.users;
  }

  findOne(id: number) {
    const user = this.users.find((user) => user.id === id);
    return user;
  }

  create(user: {
    name: string,
    email: string,
    pole: 'INTERN' | 'ENGINEER' | 'ADMIN',
  }) {
    const usersByHighestId = [...this.users].sort((a, b) => b.id - a.id)
    // Generate new user by sorting highest id then plus 1
    const newUser = [
      id: usersByHighestId[0].id + 1,
      ...user
    ]

    this.users.push(newUser)
    return newUser
  }

  update(id: number, updatedUser: {
    name?: string,
    email?: string,
    pole?: 'INTERN' | 'ENGINEER' | 'ADMIN',
  }) {
    this.users = this.users.map(user => {
      if(user.id === id ) {
        return {...user, ...updatedUser}
      }
      return user
    })
    return this.findOne(id)
  }

  delete(id: number) {
    const removedUser = this.findOne(id)
    this.users = this.users.filter(user => user.id !== id )
    return removedUser
  }
}
```

With same functions as the controller to be injectable
Import it in `users.controller.ts`:

```ts
import { UsersService } from "./users.service.ts";
```

Now apply it in controller functions by Dependency Injection, that mean the NestJS will understand it is singleton and return defined instance

Here complete UsersController:

```ts
Controller("users"); // /users
export class UsersController {
  constructor(private readonly usersService: UsersService) {}

  @Get() // GET /users
  findAll(@Query("role") role?: "INTERN" | "ENGINEER" | "ADMIN") {
    // Using the service
    return this.usersService.findAll(role);
  }

  @Get(":id") // GET /users/:id
  findOne(@Param("id") id: string) {
    /* Param are always string but service params is number
     * so add unary (+) to convert it to a number*/
    return this.usersService.findOne(+id);
  }

  @Get("interns") // GET /users/:id
  findAllInterns() {
    return [];
  }

  @Post() // POST /users
  create(
    @Body()
    user: {
      // Next chapter will learn a way to not redefine this user
      name: string;
      email: string;
      pole: "INTERN" | "ENGINEER" | "ADMIN";
    },
  ) {
    return this.usersService.create(user);
  }

  @Patch(":id") // GET /users/:id
  update(
    @Param("id") id: string,
    @Body()
    userUpdate: {
      name?: string;
      email?: string;
      pole?: "INTERN" | "ENGINEER" | "ADMIN";
    },
  ) {
    return this.usersService.update(+id, userUpdate);
  }

  @Delete(":id")
  delete(@Param("id") id: string) {
    return this.usersService.update(+id);
  }
}
```

### Get

Now when `npm run start:dev` and this POSTMAN `locahost:3000/users` will return this

```sorting[
    {
        "id": 1,
        "name": "Leanne Graham",
        "email": "Sincere@april.biz",
        "role": "INTERN"
    },
    {
        "id": 2,
        "name": "Ervin Howell",
        "email": "Shanna@melissa.tv",
        "role": "INTERN"
    },
    {
        "id": 3,
        "name": "Clementine Bauch",
        "email": "Nathan@yesenia.net",
        "role": "ENGINEER"
    },
    {
        "id": 4,
        "name": "Patricia Lebsack",
        "email": "Julianne.OConner@kory.org",
        "role": "ENGINEER"
    },
    {
        "id": 5,
        "name": "Chelsey Dietrich",
        "email": "Lucio_Hettinger@annie.ca",
        "role": "ADMIN"
    }
]
```

### Create

And the `Create` method in POSTMAN `locahost:3000/users` with

```json
Body: {
    "name": "K",
    "email": "dave@example.com",
    "role": "ADMIN"
}
```

Will return this new id for new user:

```json
{
  "id": 6,
  "name": "K",
  "email": "dave@example.com",
  "role": "ADMIN"
}
```

New users list will be updated:

```json
[
  {
    "id": 1,
    "name": "Leanne Graham",
    "email": "Sincere@april.biz",
    "role": "INTERN"
  },
  {
    "id": 2,
    "name": "Ervin Howell",
    "email": "Shanna@melissa.tv",
    "role": "INTERN"
  },
  {
    "id": 3,
    "name": "Clementine Bauch",
    "email": "Nathan@yesenia.net",
    "role": "ENGINEER"
  },
  {
    "id": 4,
    "name": "Patricia Lebsack",
    "email": "Julianne.OConner@kory.org",
    "role": "ENGINEER"
  },
  {
    "id": 5,
    "name": "Chelsey Dietrich",
    "email": "Lucio_Hettinger@annie.ca",
    "role": "ADMIN"
  },
  {
    "id": 6,
    "name": "K",
    "email": "dave@example.com",
    "role": "ADMIN"
  }
]
```
