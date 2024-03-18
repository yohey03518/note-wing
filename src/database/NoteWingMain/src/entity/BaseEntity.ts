import {Column, PrimaryGeneratedColumn} from "typeorm";

export class BaseEntity {
    @PrimaryGeneratedColumn()
    Id: number;

    @Column()
    CreatedOn: Date;

    @Column({length: 50})
    CreatedBy: string;

    @Column({nullable: true})
    ModifiedOn: Date;

    @Column({nullable: true, length: 50})
    ModifiedBy: string;
}