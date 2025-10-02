import {
  Delete,
  Patch,
  Post,
  Body,
  Controller,
  Query,
  Param,
  Get,
} from '@nestjs/common';
import { UsersService } from './users.service';

// Nestjs is running predefine function here
@Controller('users') // /users
export class UsersController {
  constructor(private readonly usersService: UsersService) {}

  @Get() // GET /users
  findAll(@Query('role') role?: 'INTERN' | 'ENGINEER' | 'ADMIN') {
    // Using the service
    return this.usersService.findAll(role);
  }

  @Get(':id') // GET /users/:id
  findOne(@Param('id') id: string) {
    /* Param are always string but service params is number
     * so add unary (+) to convert it to a number*/
    return this.usersService.findOne(+id);
  }

  @Get('interns') // GET /users/:id
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
      role: 'INTERN' | 'ENGINEER' | 'ADMIN';
    },
  ) {
    return this.usersService.create(user);
  }

  @Patch(':id') // GET /users/:id
  update(
    @Param('id') id: string,
    @Body()
    userUpdate: {
      name?: string;
      email?: string;
      pole?: 'INTERN' | 'ENGINEER' | 'ADMIN';
    },
  ) {
    return this.usersService.update(+id, userUpdate);
  }

  @Delete(':id')
  delete(@Param('id') id: string) {
    return this.usersService.delete(+id);
  }
}
