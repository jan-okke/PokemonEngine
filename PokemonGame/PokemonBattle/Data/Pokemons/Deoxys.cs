using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Deoxys : Pokemon
	{
		public override string Name => "Deoxys";
		public override List<Ability> AvailableAbilities => new() {new Pressure() };
		public override Stats BaseStats => new Stats(50, 150, 50, 150, 50, 150);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Leer(), new Wrap() },
			[7] = new List<Move>() { new Nightshade() },
			[13] = new List<Move>() { new Teleport() },
			[19] = new List<Move>() { new Knockoff() },
			[25] = new List<Move>() { new Toxicspikes() },
			[31] = new List<Move>() { new Psychic() },
			[37] = new List<Move>() { new Switcheroo() },
			[43] = new List<Move>() { new Psychoshift() },
			[49] = new List<Move>() { new Zenheadbutt() },
			[55] = new List<Move>() { new Cosmicpower() },
			[61] = new List<Move>() { new Recover() },
			[67] = new List<Move>() { new Psychoboost() },
			[73] = new List<Move>() { new Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Allyswitch(), new Avalanche(), new Bind(), new Brickbreak(), new Brutalswing(), new Calmmind(), new Chargebeam(), new Confide(), new Cut(), new Darkpulse(), new Doubleteam(), new Drainpunch(), new Dreameater(), new Endure(), new Energyball(), new Facade(), new Firepunch(), new Flash(), new Flashcannon(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gigaimpact(), new Grassknot(), new Gravity(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Icywind(), new Knockoff(), new Laserfocus(), new Lightscreen(), new Lowkick(), new Lowsweep(), new Magiccoat(), new Nastyplot(), new Poisonjab(), new Poweruppunch(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Return(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roleplay(), new Round(), new Safeguard(), new Shadowball(), new Shockwave(), new Signalbeam(), new Skillswap(), new Sleeptalk(), new Snatch(), new Snore(), new Solarbeam(), new Stealthrock(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Telekinesis(), new Throatchop(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Torment(), new Trick(), new Trickroom(), new Waterpulse(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 608;
		public override int ExpYield => 300;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}