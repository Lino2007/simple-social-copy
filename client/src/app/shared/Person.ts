import { ApiEntity } from "./BaseEntity";

export interface Person extends ApiEntity {
    firstname: string;
    lastname: string;
    nickname?: string;
    bio?: string;
    email?: string;
    country: string;
    dateOfBirth?: Date;
}