using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mismagius : Pokemon
	{
		public override string Name => "Mismagius";
		public override List<Ability> AvailableAbilities => new() {new Levitate() };
		public override Stats BaseStats => new Stats(60, 60, 60, 105, 105, 105);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Mysticalfire(), new Powergem(), new Phantomforce(), new Magicalleaf(), new Growl(), new Spite(), new Astonish() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Allyswitch(), new Attract(), new Calmmind(), new Chargebeam(), new Confide(), new Darkpulse(), new Dazzlinggleam(), new Doubleteam(), new Dreameater(), new Echoedvoice(), new Embargo(), new Endure(), new Energyball(), new Facade(), new Flash(), new Foulplay(), new Frustration(), new Gigaimpact(), new Healbell(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icywind(), new Laserfocus(), new Magiccoat(), new Magicroom(), new Nastyplot(), new Painsplit(), new Payback(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Rest(), new Return(), new Round(), new Shadowball(), new Shockwave(), new Skillswap(), new Sleeptalk(), new Snatch(), new Snore(), new Spite(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Telekinesis(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Torment(), new Trick(), new Trickroom(), new Uproar(), new Willowisp(), new Wonderroom() };
		public override int Weight => 44;
		public override int ExpYield => 173;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}