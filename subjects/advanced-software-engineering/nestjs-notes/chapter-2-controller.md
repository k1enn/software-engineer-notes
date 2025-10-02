[[chaper-1-introduction]]: Learn about how to init NestJS project, the file structure and their relationship (controller, provide, services...).

# Chapter 2

This chapter we focus on controller
Controller is response for handling request and return responses

Here the routes list we gonna create:

```
   GET /users
   GET /users/:id
   POST /users
   PATCH /users/:id
   DELETE /users/:id
```

### The problem:

In this UserController:

```@Get() // GET /users
  @Get() // GET /users
  findAll() {
    return [];
  }

  @Get(':id') // GET /users/:id
  findOne(@Param('id') id: string) {
    return { id };
  }

  @Get('interns') // GET /users/:id
  findAllInterns() {
    return [];
  }
```

### Complete `users.controller.ts` in this chapter

```import {
  Patch,
  Post,
  Body,
  Controller,
  Query,
  Param,
  Get,
} from '@nestjs/common';

// Nestjs is running predefine function here
@Controller('users') // /users
export class UsersController {
  /*
   DELETE /users/:id
   */
  @Get() // GET /users
  findAll(@Query('role') role?: 'INTERN' | 'ENGINEER' | 'ADMIN') {
    return [];
  }

  @Get(':id') // GET /users/:id
  findOne(@Param('id') id: string) {
    return { id };
  }

  @Get('interns') // GET /users/:id
  findAllInterns() {
    return [];
  }

  @Post() // POST /users
  create(@Body() user: {}) {
    return user;
  }

  @Patch(':id') // GET /users/:id
  update(@Param('id') id: string, @Body() userUpdate: {}) {
    return { id, ...userUpdate };
  }

  @Delete(':id')
  delete(@Param('id') id: string) {
    return { id };
  }
}
```
