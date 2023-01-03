import { ApiEntity } from "./BaseEntity";

export interface PersonBan extends ApiEntity {
    active: boolean;
    activeUntil: Date;
    reason: string;
    personId?: string;
}