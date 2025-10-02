[[0-introduction-nestjs]]
### Install NestJS CLI globally with
```npm
npm i -g @nestjs/cli 
```

#### Init new project
```
nest new <name>
```

### Create a new module:
```
nest g module users 
```

**After install new module** here is the `users` it will **automatically import** to root `app.module.ts`:
```ts
import { Module } from '@nestjs/common';
import { AppController } from './app.controller';
import { AppService } from './app.service';
import { UsersModule } from './users/users.module';

@Module({
  imports: [UsersModule], // <=== Here
  controllers: [AppController],
  providers: [AppService],
})
export class AppModule {}

```

### Create a new controller
```
nest g controller users
```

### Create a new service
```
nest g service users 
```

Now we can do the routing logic, other things...
Go to [[chapter-2-controller]]