using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gengar : Pokemon
	{
		public override string Name => "Gengar";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Cursedbody() };
		public override Stats BaseStats => new Stats(60, 65, 60, 130, 75, 110);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Shadowpunch(), new Moves.Perishsong(), new Moves.Reflecttype(), new Moves.Lick(), new Moves.Confuseray(), new Moves.Hypnosis(), new Moves.Meanlook() },
			[12] = new List<Move>() { new Moves.Payback() },
			[16] = new List<Move>() { new Moves.Spite() },
			[20] = new List<Move>() { new Moves.Curse() },
			[24] = new List<Move>() { new Moves.Hex() },
			[30] = new List<Move>() { new Moves.Nightshade() },
			[36] = new List<Move>() { new Moves.Suckerpunch() },
			[42] = new List<Move>() { new Moves.Darkpulse() },
			[48] = new List<Move>() { new Moves.Shadowball() },
			[54] = new List<Move>() { new Moves.Destinybond() },
			[60] = new List<Move>() { new Moves.Dreameater() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Corrosivegas(), new Moves.Darkpulse(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Explosion(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Foulplay(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Phantomforce(), new Moves.Poisonjab(), new Moves.Poltergeist(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Scaryface(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Skillswap(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Torment(), new Moves.Toxic(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Venoshock(), new Moves.Willowisp(), new Moves.Wonderroom() };
		public override int Weight => 405;
		public override int ExpYield => 250;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}