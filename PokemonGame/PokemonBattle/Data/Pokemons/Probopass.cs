using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Probopass : Pokemon
	{
		public override string Name => "Probopass";
		public override List<Ability> AvailableAbilities => new() {new Sturdy(), new Magnetpull() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandforce() };
		public override Stats BaseStats => new Stats(60, 55, 145, 40, 75, 150);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Triattack() },
			[1] = new List<Move>() { new Triattack(), new Magneticflux(), new Magnetrise(), new Gravity(), new Wideguard(), new Tackle(), new Irondefense(), new Block() },
			[4] = new List<Move>() { new Irondefense() },
			[7] = new List<Move>() { new Block() },
			[10] = new List<Move>() { new Smackdown() },
			[13] = new List<Move>() { new Thunderwave() },
			[16] = new List<Move>() { new Rest() },
			[19] = new List<Move>() { new Spark() },
			[22] = new List<Move>() { new Rockslide() },
			[25] = new List<Move>() { new Powergem() },
			[28] = new List<Move>() { new Rockblast() },
			[31] = new List<Move>() { new Discharge() },
			[34] = new List<Move>() { new Sandstorm() },
			[37] = new List<Move>() { new Earthpower() },
			[40] = new List<Move>() { new Stoneedge() },
			[43] = new List<Move>() { new Lockon(), new Zapcannon() },
			[50] = new List<Move>() { new Bodypress() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Block(), new Bulldoze(), new Confide(), new Dazzlinggleam(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Explosion(), new Facade(), new Firepunch(), new Flashcannon(), new Frustration(), new Gigaimpact(), new Gravity(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Irondefense(), new Ironhead(), new Magiccoat(), new Magnetrise(), new Painsplit(), new Protect(), new Rest(), new Return(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Shockwave(), new Sleeptalk(), new Smackdown(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Telekinesis(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Torment(), new Voltswitch() };
		public override int Weight => 3400;
		public override int ExpYield => 184;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}