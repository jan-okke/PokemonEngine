using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Girafarig : Pokemon
	{
		public override string Name => "Girafarig";
		public override List<Ability> AvailableAbilities => new() {new Innerfocus(), new Earlybird() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sapsipper() };
		public override Stats BaseStats => new Stats(70, 80, 65, 85, 90, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Powerswap(), new Guardswap(), new Astonish(), new Tackle(), new Growl() },
			[5] = new List<Move>() { new Confusion() },
			[10] = new List<Move>() { new Assurance() },
			[14] = new List<Move>() { new Stomp() },
			[19] = new List<Move>() { new Psybeam() },
			[23] = new List<Move>() { new Agility() },
			[28] = new List<Move>() { new Doublehit() },
			[32] = new List<Move>() { new Zenheadbutt() },
			[37] = new List<Move>() { new Crunch() },
			[41] = new List<Move>() { new Batonpass() },
			[46] = new List<Move>() { new Nastyplot() },
			[50] = new List<Move>() { new Psychic() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Bulldoze(), new Calmmind(), new Chargebeam(), new Confide(), new Dazzlinggleam(), new Doubleteam(), new Dreameater(), new Earthquake(), new Echoedvoice(), new Endure(), new Energyball(), new Facade(), new Flash(), new Foulplay(), new Frustration(), new Grassknot(), new Gravity(), new Hiddenpower(), new Hypervoice(), new Irontail(), new Lightscreen(), new Magiccoat(), new Nastyplot(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Return(), new Rocksmash(), new Round(), new Shadowball(), new Shockwave(), new Signalbeam(), new Skillswap(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Telekinesis(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Trick(), new Trickroom(), new Uproar(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Amnesia(), new Beatup(), new Doublekick(), new Futuresight(), new Magiccoat(), new Meanlook(), new Mirrorcoat(), new Takedown(), new Wish() };
		public override int Weight => 415;
		public override int ExpYield => 159;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}