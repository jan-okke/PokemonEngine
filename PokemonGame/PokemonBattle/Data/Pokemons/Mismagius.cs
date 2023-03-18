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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Levitate() };
		public override Stats BaseStats => new Stats(60, 60, 60, 105, 105, 105);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Mysticalfire(), new Moves.Powergem(), new Moves.Phantomforce(), new Moves.Magicalleaf(), new Moves.Growl(), new Moves.Spite(), new Moves.Astonish() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Allyswitch(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Darkpulse(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Echoedvoice(), new Moves.Embargo(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Foulplay(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Healbell(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icywind(), new Moves.Laserfocus(), new Moves.Magiccoat(), new Moves.Magicroom(), new Moves.Nastyplot(), new Moves.Painsplit(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snatch(), new Moves.Snore(), new Moves.Spite(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Telekinesis(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Willowisp(), new Moves.Wonderroom() };
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