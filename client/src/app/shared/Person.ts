import { BaseEntity } from "./BaseEntity";

export interface Person extends BaseEntity {
    firstname: string;
    lastname: string;
    nickname?: string;
    bio?: string;
    email?: string;
    country: string;
    dateOfBirth?: Date;
}