import { BaseEntity } from "./BaseEntity";

export interface PersonBan extends BaseEntity {
    active: boolean;
    activeUntil: Date;
    reason: string;
    personId?: string;
}