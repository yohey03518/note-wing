import {Column, Entity} from "typeorm"
import {BaseEntity} from "./BaseEntity";

@Entity()
export class NoteCategory extends BaseEntity{
    @Column({length: 100})
    name: string
}
