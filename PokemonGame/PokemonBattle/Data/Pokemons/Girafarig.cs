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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Innerfocus(), new Abilities.Earlybird() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sapsipper() };
		public override Stats BaseStats => new Stats(70, 80, 65, 90, 65, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Powerswap(), new Moves.Guardswap(), new Moves.Astonish(), new Moves.Tackle(), new Moves.Growl() },
			[5] = new List<Move>() { new Moves.Confusion() },
			[10] = new List<Move>() { new Moves.Assurance() },
			[14] = new List<Move>() { new Moves.Stomp() },
			[19] = new List<Move>() { new Moves.Psybeam() },
			[23] = new List<Move>() { new Moves.Agility() },
			[28] = new List<Move>() { new Moves.Doublehit() },
			[32] = new List<Move>() { new Moves.Zenheadbutt() },
			[37] = new List<Move>() { new Moves.Crunch() },
			[41] = new List<Move>() { new Moves.Batonpass() },
			[46] = new List<Move>() { new Moves.Nastyplot() },
			[50] = new List<Move>() { new Moves.Psychic() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Earthquake(), new Moves.Echoedvoice(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Foulplay(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Gravity(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Magiccoat(), new Moves.Nastyplot(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Signalbeam(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Telekinesis(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Workup(), new Moves.Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Beatup(), new Moves.Doublekick(), new Moves.Futuresight(), new Moves.Magiccoat(), new Moves.Meanlook(), new Moves.Mirrorcoat(), new Moves.Takedown(), new Moves.Wish() };
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